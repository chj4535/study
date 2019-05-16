using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer.ViewModels.Command;
using Timer.Models;
using System.Collections.ObjectModel;
using Timer.Views;
using System.Windows;
using System.ComponentModel;
using System.Threading;
using System.Windows.Documents;

namespace Timer.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainModel mainModel;//값을 가공하는 모델
        public EditRequestWindow editRequestwindow;//request입,출력창

        public string txt_serverIp { get; set; }
        public string txt_requestTitle { get; set; } //editrequset창에서 title값
        public string txt_agentKey { get; set; }//입력받을 에이전트키
        public ObservableCollection<MyListBoxItem> agentKeylist { get; private set; }
        public ObservableCollection<MyListBoxItem> requestList { get; private set; } //리퀘스트 리스트

        /////////button setting//////////////
        public DelegateCommand openEditrequestwindow { get; private set; } //리퀘스트 edit창 열기
        public DelegateCommand openShowrequestwindow { get; private set; } //리퀘스트 show창 열기
        public DelegateCommand addAgentkey { get; private set; } //에이전트키를 추가
        public DelegateCommand removeAgentkey { get; private set; } //에이전트키를 삭제
        public DelegateCommand addRequest { get; private set; }//리퀘스트 추가
        public DelegateCommand removeRequest { get; private set; } //리퀘스트 삭제
        public DelegateCommand setServerip { get; private set; }//ip설정

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(String info)
        {
            if (PropertyChanged != null)

                PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

        public MainViewModel()
        {
            mainModel = new MainModel();
            SetValue();
            SetCommand();
        }

        private void SetValue()
        {
            agentKeylist = mainModel.agentKeylist;
            requestList = mainModel.requestList;
            txt_agentKey = "";
            txt_serverIp = mainModel.serverIp;
        }
        private void SetCommand()
        {
            openEditrequestwindow = new DelegateCommand(OpenEditRequestWindow);
            openShowrequestwindow = new DelegateCommand(OpenShowRequestWindow);
            addAgentkey = new DelegateCommand(AddAgentKey);
            removeAgentkey = new DelegateCommand(RemoveAgentKey);
            removeRequest = new DelegateCommand(RemoveRequest);
            addRequest = new DelegateCommand(AddRequest);
            setServerip = new DelegateCommand(SetServerIP);
        }



        public void SetServerIP(object obj)
        {
            mainModel.SaveServerIP(txt_serverIp);
        }

        ////////////agent_key////////////////////

        public void AddAgentKey(object obj)
        {
            if (txt_agentKey != "")
            {
                string agentKey = txt_agentKey;
                txt_agentKey = ""; //에이전트키 입력창 초기화
                OnPropertyChanged("txt_agentKey"); //입력창 변화 알림
                mainModel.SaveAgentKey(agentKey);//에이전트키 저장
                agentKeylist = mainModel.agentKeylist;
            }
        }

        public void RemoveAgentKey(object obj)
        {
            if (obj != null) // 선택 됐으면
            {
                MyListBoxItem listBoxitem = obj as MyListBoxItem;
                mainModel.RemoveAgentKey(listBoxitem);
                agentKeylist = mainModel.agentKeylist;
            }
        }

        ////////////request////////////////////

        public void OpenEditRequestWindow(object obj)
        {
            editRequestwindow = new EditRequestWindow("", this);
            editRequestwindow.Owner = Application.Current.MainWindow;
            txt_requestTitle = "";
            OnPropertyChanged("txt_requestTitle");
            editRequestwindow.ShowDialog();
        }

        public void OpenShowRequestWindow(object obj)
        {
            if (obj != null)
            {
                Console.Write(obj);
                MyListBoxItem listBoxitem = obj as MyListBoxItem;
                string title = listBoxitem.content;
                string fileTostring = mainModel.LoadRequest(title);

                editRequestwindow = new EditRequestWindow(fileTostring, this);
                editRequestwindow.Owner = Application.Current.MainWindow;
                txt_requestTitle = title;
                OnPropertyChanged("txt_requestTitle");
                editRequestwindow.ShowDialog();
            }
        }


        public void AddRequest(object obj)
        {
            editRequestwindow.Close(); //request 입력창 닫기
            FlowDocument requestDocument = obj as FlowDocument;
            mainModel.SaveRequest(txt_requestTitle, requestDocument);
            requestList = mainModel.requestList;
        }
        public void RemoveRequest(object obj)
        {
            if (obj != null) //선택 됐으면
            {
                MyListBoxItem listBoxitem = obj as MyListBoxItem;
                mainModel.RemoveRequest(listBoxitem);
                requestList = mainModel.requestList;
            }
        }
    }
}
