using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using System.IO.Pipes;

namespace Timer.Models
{    
    public class MyListBoxItem
    {
        public MyListBoxItem(int index, string content)
        {
            this.index = index;
            this.content = content;
        }
        public int index { get; set; }
        public string content { get; set; }
    }

    public class MainModel
    {
        public string currentDirpath; //set폴더까지
        public string agentKeypath; //파일까지
        public string requestPath; //폴더까지
        public string configPath; //파일까지
        
        public string serverIp { get; private set; }
        public ObservableCollection<MyListBoxItem> agentKeylist { get; private set; }
        public ObservableCollection<MyListBoxItem> requestList { get; private set; }

        public MainModel()
        {
            agentKeylist = new ObservableCollection<MyListBoxItem>();
            requestList = new ObservableCollection<MyListBoxItem>();

            CheckSet(); // 초기 폴더, 파일 존재 여부 확인하고 생성
            LoadSet();
        }

        public void CheckSet()
        {
            currentDirpath = Directory.GetCurrentDirectory(); // 현재 폴더 확인
            currentDirpath += "\\Set";
            agentKeypath = currentDirpath + "\\AgentKey";
            configPath = currentDirpath + "\\config";
            requestPath = currentDirpath + "\\Request";
            Directory.CreateDirectory(currentDirpath);
            Directory.CreateDirectory(agentKeypath);
            Directory.CreateDirectory(requestPath);
            agentKeypath += "\\AgentKey.txt";
            if (!File.Exists(agentKeypath))
            {
                FileStream fs = File.Create(agentKeypath);
                fs.Close();
            }
            if (!File.Exists(configPath))
            {
                FileStream fs = File.Create(configPath);
                string defaultIP = "Server:127.0.0.1";
                byte[] info = new UTF8Encoding(true).GetBytes(defaultIP);
                fs.Write(info, 0, info.Length);
                fs.Close();
            }
        }

        public void LoadSet()
        {
            string[] agentKeys = File.ReadLines(agentKeypath).ToArray(); //에이전트 키 모음
            foreach (string agentKey in agentKeys)
            {
                if (agentKey != "")
                    AddAgentKey(agentKey);
            }
            string[] requests = Directory.GetFiles(requestPath);
            foreach (string request in requests)
            {
                AddRequest(request);
            }
            string[] configs = File.ReadLines(configPath).ToArray(); //에이전트 키 모음
            serverIp = configs[0].Split(':').Last();
        }

        ////////////config////////////

        public void SaveServerIP(string serverIp)
        {
            if (this.serverIp != serverIp)
            {
                var file = new List<string>(System.IO.File.ReadAllLines(configPath));
                file[0] = "server:" + serverIp;
                File.WriteAllLines(configPath, file.ToArray());
                this.serverIp = serverIp;
            }
        }

        ////////////////////agent/////////////////////////////////

        public void AddAgentKey(string agentKey)
        {
            agentKeylist.Add(new MyListBoxItem(agentKeylist.Count,agentKey));
        }

       
        public void SaveAgentKey(string agentKey)
        {
            agentKeylist.Add(new MyListBoxItem(agentKeylist.Count,agentKey));
            using (StreamWriter sw = File.AppendText(agentKeypath))
            {
                sw.WriteLine(agentKey);
                sw.Close();
            }
        }
        public void RemoveAgentKey(MyListBoxItem listBoxitem)
        {
            int index = agentKeylist.IndexOf(listBoxitem);
            agentKeylist.RemoveAt(index);
            var file = new List<string>(System.IO.File.ReadAllLines(agentKeypath));
            file.RemoveAt(index);
            File.WriteAllLines(agentKeypath, file.ToArray());
        }


        ////////////////////request/////////////////////////////

        public void AddRequest(string request)
        {
            requestList.Add(new MyListBoxItem(requestList.Count, request.Split('\\').Last().Split('.').First()));
        }

        public string LoadRequest(string fileName)
        {
            string filePath = requestPath + "\\" + fileName + ".json";
            string fileTostring = System.IO.File.ReadAllText(filePath);
            return fileTostring;
        }
        public void RemoveRequest(MyListBoxItem listBoxitem)
        {
            int index = requestList.IndexOf(listBoxitem);
            string title = listBoxitem.content;
            requestList.RemoveAt(index);
            File.Delete(requestPath + '\\' + title + ".json");
        }

        public void SaveRequest(string title, FlowDocument requestDocument)
        {
            TextRange textRange = new TextRange(requestDocument.ContentStart, requestDocument.ContentEnd);
            string content = textRange.Text;
            File.WriteAllText(requestPath + '\\' + title + ".json", content);
            foreach (MyListBoxItem item in requestList)
            {
                if (item.content == title)
                    return;
            }
            requestList.Add(new MyListBoxItem(requestList.Count, title));
        }
    }
}