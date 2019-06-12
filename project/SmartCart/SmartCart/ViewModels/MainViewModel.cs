using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using SmartCart.Models;
using SmartCart.ViewModels.command;

namespace SmartCart.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        MainModel mainModel = new MainModel();
        public DelegateCommand BucketCountMinusCommand { get; private set; }
        public DelegateCommand PurchaseCommand { get; private set; }
        public DelegateCommand BucketCountPlusCommand { get; private set; }
        public DelegateCommand SelectCategoryCommand { get; private set; }
        public DelegateCommand SearchItemCommand { get; private set; }
        public DelegateCommand CountChangeCommand { get; private set; }
        public DelegateCommand AddBasketCommand { get; private set; }
        public string clientName { get; set; }
        public List<Item> bestSellingitems { get; set; }
        public List<Item> sailingItems { get; set; }
        //public List<Bucket> bucketList { get; set; }
        private ObservableCollection<Bucket> _bucketList;
        public ObservableCollection<Bucket> bucketList
        {
            get { return _bucketList; }
            set
            {
                _bucketList = value;
                OnPropertyChanged("bucketList");
            }
        }
        public string searchItemvisible { get; set; }
        public int subTotal { get; set; }
        public int tex { get; set; }
        public int totalPrice { get; set; }
        public Item searchItems { get; set; }
        public int bucketCount { get; set; }
        public string visibleState { get; set; }
        public int productCount { get; set; }
        private int selectedTabindex;
        public int SelectedTabindex
        {
            get
            {
                return selectedTabindex;
            }
            set
            {
                ClickTab(value);
                selectedTabindex = value;
            }
        }

        public MainViewModel()
        {
            visibleState = "Hidden";
            PurchaseCommand = new DelegateCommand(purchase);
            BucketCountMinusCommand = new DelegateCommand(BucketCountMinus);
            BucketCountPlusCommand = new DelegateCommand(BucketCountPlus);
            SelectCategoryCommand = new DelegateCommand(SelectCategory);
            SearchItemCommand = new DelegateCommand(SearchItem);
            CountChangeCommand = new DelegateCommand(CountChange);
            AddBasketCommand = new DelegateCommand(AddBasket);
            clientName = mainModel.clientName;
            OnPropertyChanged("clientName");
            SelectedTabindex = 0;
        }
        public void purchase(object sender)
        {
            mainModel.PrintPurchase();
            MessageBox.Show("구매 완료!", "확인", MessageBoxButton.OK, MessageBoxImage.Information);
            System.Windows.Application.Current.Shutdown();

        }
        public void BucketCountMinus(object sender)
        {
            TextBlock tb = sender as TextBlock;
            string itemID = tb.Text.ToString();
            bucketList = null;
            OnPropertyChanged("bucketList");
            bucketList = mainModel.BucketCountMinus(itemID);
            subTotal = mainModel.GetTotalPrice();
            OnPropertyChanged("subTotal");
            tex = subTotal / 10;
            OnPropertyChanged("tex");
            totalPrice = subTotal + tex;
            OnPropertyChanged("totalPrice");
            OnPropertyChanged("bucketList");
        }

        public void BucketCountPlus(object sender)
        {
            TextBlock tb = sender as TextBlock;
            string itemID = tb.Text.ToString();
            bucketList = null;
            OnPropertyChanged("bucketList");
            bucketList = mainModel.BucketCountPlus(itemID);
            subTotal = mainModel.GetTotalPrice();
            OnPropertyChanged("subTotal");
            tex = subTotal / 10;
            OnPropertyChanged("tex");
            totalPrice = subTotal + tex;
            OnPropertyChanged("totalPrice");
            OnPropertyChanged("bucketList");
        }

        public void CountChange(object sender)
        {
            string countType = sender as string;
            switch (countType)
            {
                case "-":
                    if (productCount > 0) {
                        productCount--;
                        OnPropertyChanged("productCount");
                    }
                    break;
                case "+":
                    productCount++;
                    OnPropertyChanged("productCount");
                    break;
            }
        }

        public void ClickTab(int selectIndex)
        {
            switch (selectIndex) {
                case 0:
                    bestSellingitems = mainModel.BestSailitems();
                    OnPropertyChanged("bestSellingitems");
                    break;
                case 1:
                    sailingItems = mainModel.SailingItems();
                    OnPropertyChanged("sailingItems");
                    break;
                case 2:
                    searchItems = null;
                    visibleState = "Hidden";
                    OnPropertyChanged("visibleState");
                    OnPropertyChanged("searchItems");
                    break;
                case 3:
                    bucketList = null;
                    OnPropertyChanged("bucketList");
                    subTotal = mainModel.GetTotalPrice();
                    OnPropertyChanged("subTotal");
                    tex = subTotal/10;
                    OnPropertyChanged("tex");
                    totalPrice = subTotal + tex;
                    OnPropertyChanged("totalPrice");
                    bucketList = mainModel.GetBucketList();
                    OnPropertyChanged("bucketList");
                    break;
            }
        }

        public void AddBasket(object sender) //장바구니에 추가
        {
            if (productCount == 0)
            {
                MessageBox.Show("수량을 선택해 주세요!","에러", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("장바구니 추가!", "확인", MessageBoxButton.OK, MessageBoxImage.Information);
                bucketList = mainModel.AddBasket(searchItems, productCount);
                OnPropertyChanged("bucketList");
            }
        }

        public void SearchItem(object sender) //아이템 검색
        {
            TextBox tb = sender as TextBox;
            string searchText = tb.Text.ToString();
            searchItems = mainModel.SearchItem(searchText);
            OnPropertyChanged("searchItems");
            if (searchItems != null) //  아이템 찾음
            {
                productCount = 0;
                OnPropertyChanged("productCount");
                visibleState = "Visible"; //수량선택 + 장바구니창 출현
                if (searchItems.DiscountRate == 0)
                {
                    searchItemvisible = "Hidden";
                    OnPropertyChanged("searchItemvisible");
                }
                else
                {
                    searchItemvisible = "Visible";
                    OnPropertyChanged("searchItemvisible");
                }
            }
            else
            {
                visibleState = "Hidden"; 
            }
            OnPropertyChanged("visibleState");
        }

        public void SelectCategory(object sender)
        {
            string type = sender as string;
            sailingItems = mainModel.SelectCategory(type);
            OnPropertyChanged("sailingItems");
        }

        public Item GetItem(string itemID)
        {
            return mainModel.GetItem(itemID);
        }
    }
}
