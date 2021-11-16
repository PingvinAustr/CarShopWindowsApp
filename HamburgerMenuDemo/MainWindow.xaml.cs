using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace HamburgerMenuDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window, ICommand
    {

        string name_tab = "";

        public string myString { get; set; }

        User chosenUser = new User(0, 0, "", "", "0", "", "");
        public MainWindow()
        {
            InitializeComponent();
          
            HowdyTextBox.Text = "Howdy, \n" + CurrentUser.userName;
            
            //chosenUser = receiveUser;
        }
        string isOpened = "";
        string chosenItem = "";
        public event EventHandler CanExecuteChanged;

        protected static string connectionString = @"Data Source=MSI;Initial Catalog=CarShop;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public void SetUpDB(object sender, RoutedEventArgs e)
        {
            connection.Open();
        }


        public bool CanExecute(object parameter)
        {

            return true;
        }

        public void Execute(object parameter)
        {
            //MessageBox.Show("Selection Binding");
        }
        /*
        public class CarsTable
        {
            //string carID, carModelID, carOwnerID, carType, carCategory, carDesc, carPrice;

            public string carID { get; set; }
            public string carModelID { get; set; }
            public string carOwnerID { get; set; }
            public string carType { get; set; }
            public string carCategory { get; set; }
            public string carDesc { get; set; }
            public string carPrice { get; set; }



            public CarsTable(string d1, string d2, string d3, string d4, string d5, string d6, string d7)
            {
                carID = d1;
                carModelID = d2;
                carOwnerID = d3;
                carType = d4;
                carCategory = d5;
                carDesc = d6;
                carPrice = d7;
            }
        }

        public class CarTechInfo
        {
            //string carModelID, carMark, carModelName, carComplectation, carPower, carGear, carEngine, carFuelTank, carPlaces, carFuelConsumption;

            public string carModelID { get; set; }
            public string carMark { get; set; }
            public string carModelName { get; set; }
            public string carComplectation { get; set; }
            public string carPower { get; set; }
            public string carGear { get; set; }
            public string carEngine { get; set; }
            public string carFuelTank { get; set; }
            public string carPlaces { get; set; }
            public string carFuelConsumption { get; set; }



            public CarTechInfo(string d1, string d2, string d3, string d4, string d5, string d6, string d7, string d8, string d9, string d10)
            {
                carModelID = d1;
                carMark = d2;
                carModelName = d3;
                carComplectation = d4;
                carPower = d5;
                carGear = d6;
                carEngine = d7;
                carFuelTank = d8;
                carPlaces = d9;
                carFuelConsumption = d10;
            }
        }

        public class Contracts
        {
            //string carModelID, carMark, carModelName, carComplectation, carPower, carGear, carEngine, carFuelTank, carPlaces, carFuelConsumption;

            public string contractID { get; set; }
            public string orderID { get; set; }



            public Contracts(string d1, string d2)
            {
                contractID = d1;
                orderID = d2;
            }
        }

        public class Orders
        {
            //string carModelID, carMark, carModelName, carComplectation, carPower, carGear, carEngine, carFuelTank, carPlaces, carFuelConsumption;

            public string orderID { get; set; }
            public string managerID { get; set; }
            public string customerID { get; set; }
            public string orderStatus { get; set; }
            public string Price { get; set; }



            public Orders(string d1, string d2, string d3, string d4, string d5)
            {
                orderID = d1;
                managerID = d2;
                customerID = d3;
                orderStatus = d4;
                Price = d5;
            }
        }

        public class Requirements
        {
            //string carModelID, carMark, carModelName, carComplectation, carPower, carGear, carEngine, carFuelTank, carPlaces, carFuelConsumption;

            public string reqID { get; set; }
            public string customerID { get; set; }
            public string carModelID { get; set; }
            public string carCategory { get; set; }
            public string carPower { get; set; }
            public string carGear { get; set; }
            public string carEngine { get; set; }
            public string carFuelTank { get; set; }
            public string carPlaces { get; set; }
            public string Budget { get; set; }



            public Requirements(string d1, string d2, string d3, string d4, string d5, string d6, string d7, string d8, string d9, string d10)
            {
                reqID = d1;
                customerID = d2;
                carModelID = d3;
                carCategory = d4;
                carPower = d5;
                carGear = d6;
                carEngine = d7;
                carFuelTank = d8;
                carPlaces = d9;
                Budget = d10;
            }
        }

        public class Roles
        {
            //string carModelID, carMark, carModelName, carComplectation, carPower, carGear, carEngine, carFuelTank, carPlaces, carFuelConsumption;

            public string roleID { get; set; }
            public string roleName { get; set; }
            public string roleDescription { get; set; }



            public Roles(string d1, string d2, string d3)
            {
                roleID = d1;
                roleName = d2;
                roleDescription = d3;
            }
        }

        public class Users
        {
            //string carModelID, carMark, carModelName, carComplectation, carPower, carGear, carEngine, carFuelTank, carPlaces, carFuelConsumption;

            public string userID { get; set; }
            public string userRoleID { get; set; }
            public string userName { get; set; }
            public string userEmail { get; set; }
            public string userPhone { get; set; }
            public string userlogin { get; set; }
            public string userPassword { get; set; }




            public Users(string d1, string d2, string d3, string d4, string d5, string d6, string d7)
            {
                userID = d1;
                userRoleID = d2;
                userName = d3;
                userEmail = d4;
                userPhone = d5;
                userlogin = d6;
                userPassword = d7;
            }
        }
        */


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            App.Current.Windows[0].Close();
        }
       

        private void Tab1_Home_Click(object sender, RoutedEventArgs e)
        {
            inner_tabs_1_home.IsSelected = true;
            chosenItem = "1";
        }

        private void Tab2_Search_Click(object sender, RoutedEventArgs e)
        {
            inner_tabs_2_search.IsSelected = true;
            chosenItem = "2";


            switch (CurrentUser.userRoleId)
            {
                case 2: {
                        search_page_textb.Text = "Find cars on stock\nEnter mark:";
                        search_page_textb.Width *= 2;
                        search_page_combobox.Visibility = Visibility.Hidden;

                        break; }
                case 3: { search_page_textb.Text = "Find orders where your car is mentioned\nEnter car ID:";
                        search_page_textb.Width *= 2;
                        search_page_combobox.Visibility = Visibility.Hidden;        
                        break; }
                case 4: { 
                           break; }
                case 5: {  break; }
            }

        }

      
        //*
        private void Tab3_heart_Click(object sender, RoutedEventArgs e)
        {
            inner_tabs_3_heart.IsSelected = true;
            chosenItem = "3";
            string to_output_requirements = "Requirements info:";
            heart_header_text.Text = "Requirements ";



            using (UserContext db = new UserContext())
            {

                //Create list for specified requirements
                var all_requirements = db.RequirementsHere.ToList();
                var spec_requirements = all_requirements;
                spec_requirements.Clear();
                all_requirements = db.RequirementsHere.ToList();


                //Create list for all cars and specified cars
                var cars_list = db.CarsHere.ToList();
                var spec_cars_list = cars_list;
                spec_cars_list.Clear();
                cars_list = db.CarsHere.ToList();


                //Create list for all orders
                var orders_list = db.Orders_Here.ToList();
                var spec_orders_list = orders_list;
                spec_orders_list.Clear();
                orders_list = db.Orders_Here.ToList();


                switch (CurrentUser.userRoleId) {

                    case 1:
                        { databaseGrid_heart.ItemsSource = all_requirements; break; }
                    case 2:
                        {
                            //==========================Simple Customer (sees his orders and their status)
                            heart_header_text.Text = "Your orders:";
                            heart_footer_text.Text = "Your created requirements without answer:";
                            heart_footer_text.Visibility = Visibility.Visible;
                            databaseGrid_heart_bottom.Visibility = Visibility.Visible;

                            foreach (Requirements req in all_requirements)
                            {
                                if (req.customerID == CurrentUser.userId) { spec_requirements.Add(req); }
                            }

                            foreach (Orders order in orders_list)
                            {
                                if (order.customerID == CurrentUser.userId) spec_orders_list.Add(order);
                            }

                            databaseGrid_heart.ItemsSource = spec_requirements;
                            databaseGrid_heart_bottom.ItemsSource = spec_orders_list;

                             break; }
                    case 3:
                        {
                            heart_header_text.Text = "Your owned cars, which are on sale:";
                            //===================AUTO OWNER (See own cars)
                            foreach (Cars car in cars_list)
                            {
                                if (car.carOwnerID == CurrentUser.userId) { spec_cars_list.Add(car); }
                            }
                            databaseGrid_heart.ItemsSource = spec_cars_list; break; }
                    case 4:
                        {
                            //=========================================================================MANAGER (See only own clients)

                            heart_header_text.Text = "Assigned requirements:";
                            foreach (Requirements req in all_requirements)
                            {
                                
                                if (req.managerID == CurrentUser.userId) { spec_requirements.Add(req);  }
                            }
                            databaseGrid_heart.ItemsSource=spec_requirements;
  
                            break; }
                    case 5:            
                        {
                            //=========================================MAIN ADMIN (See all requirements)
                            databaseGrid_heart.ItemsSource = all_requirements;
                            heart_header_text.Text += "(admin mode)";
                            databaseGrid_heart.Height = 600;

                            break; }

                }

                }

        }

        private void Tab4_edit_Click(object sender, RoutedEventArgs e)
        {
            inner_tabs_4_edit.IsSelected = true;
            chosenItem = "4";

        }
 
        private void Tab5_Profile_Click(object sender, RoutedEventArgs e)
        {
            inner_tabs_5_profile.IsSelected = true;
            chosenItem = "5";
            forroles.Text = "Your profile info:";

            tab5_role_text.Text = CurrentUser.userRoleId.ToString();
            tab5_phone_text.Text = CurrentUser.userPhone.ToString();
            tab5_password_text.Text = CurrentUser.userPassword.ToString();
            tab5_name_text.Text = CurrentUser.userName.ToString();
            tab5_login_text.Text = CurrentUser.userLogin.ToString();
            tab5_email_text.Text = CurrentUser.userEmail.ToString();


            int pass_dots, username_dots;
            string p_dots="", u_dots="";

            pass_dots = CurrentUser.userPassword.ToString().Length;
            username_dots = CurrentUser.userLogin.ToString().Length;


            p_dots = new String('*', CurrentUser.userPassword.Length);
            u_dots = new String('*', CurrentUser.userLogin.Length);

            try
            {
                using (UserContext db = new UserContext())
                {
                    var roles = db.RolesHere.ToList();

                    for (int i = 0; i < roles.Count(); i++)
                    {
                        if (roles[i].roleID == CurrentUser.userRoleId) { tab5_role_text.Text = roles[i].roleName; }
                    }

                }
            }
            catch { MessageBox.Show("Error in --> MainWindow.xaml.cs-->Tab5_Profile_Click()"); }


                tab5_password_text.Text = p_dots;
            tab5_login_text.Text = u_dots;

            forroles.Text += "\n" + tab5_role_text.Text + " Mode";

            int number = 0;
            using (UserContext db = new UserContext()) {
                switch (CurrentUser.userRoleId)
                {

                    case 2: { profile_tab_statistics.Text = "Total number of my unanswered\n orders:\n";

                            foreach (Requirements req in db.RequirementsHere.ToList())
                            {
                                if (req.customerID == CurrentUser.userId)
                                {
                                    number++;
                                }
                            }
                            profile_tab_statistics.Text += number + "\n\nTotal number of my WIP\n orders:\n";
                            number = 0;

                            foreach (Orders order in db.Orders_Here.ToList())
                            {
                                if (order.customerID == CurrentUser.userId) { number++; }
                            }
                            profile_tab_statistics.Text += number;

                            break; }
                    case 3: { profile_tab_statistics.Text = "Total number of my cars:\n"; 
                            
                            foreach (Cars car in db.CarsHere.ToList())
                            {
                                if (car.carOwnerID == CurrentUser.userId) { number++; }
                            }

                            profile_tab_statistics.Text += number;

                            break; }
                    case 4: { profile_tab_statistics.Text = "Total number of my orders:\n";

                          
                            foreach (Requirements order in db.RequirementsHere.ToList())
                            {
                                if (order.managerID == CurrentUser.userId)
                                {
                                    number++;
                                }
                            }
                            profile_tab_statistics.Text += number;

                            break; }
                    case 5: {
                            profile_tab_statistics.Text = "Total number of users:\n";
                            var users_list = db.UsersHere.ToList();
                            profile_tab_statistics.Text += "\n" + users_list.Count();
                            profile_tab_statistics.Text += "\n\nTotal number of cars on stock:\n\n"+db.CarsHere.Count();


                            break; }

                }
            }


        }
     

        //*+err
        private void TableSelectComboBox_SelectionChanged(object sender, RoutedEventArgs e)
        {

            Data1_input.Visibility = Visibility.Visible;
            Data1_text.Visibility = Visibility.Visible;

            Data2_input.Visibility = Visibility.Visible;
            Data2_text.Visibility = Visibility.Visible;

            Data3_input.Visibility = Visibility.Visible;
            Data3_text.Visibility = Visibility.Visible;

            Data4_input.Visibility = Visibility.Visible;
            Data4_text.Visibility = Visibility.Visible;

            Data5_input.Visibility = Visibility.Visible;
            Data5_text.Visibility = Visibility.Visible;


            //databaseGrid.Items.Clear();
            Data6_input.Visibility = Visibility.Visible;
            Data6_text.Visibility = Visibility.Visible;

            Data7_input.Visibility = Visibility.Visible;
            Data7_text.Visibility = Visibility.Visible;

            Data8_input.Visibility = Visibility.Visible;
            Data8_text.Visibility = Visibility.Visible;

            Data9_input.Visibility = Visibility.Visible;
            Data9_text.Visibility = Visibility.Visible;

            Data10_input.Visibility = Visibility.Visible;
            Data10_text.Visibility = Visibility.Visible;

            try
            {

                using (UserContext db = new UserContext())
                {
                    var users_list = db.UsersHere.ToList();
                    var requirements_list = db.RequirementsHere.ToList();
                    var cars_list = db.CarsHere.ToList();
                    var cartechinfo_list = db.CarTechInfoHere.ToList();
                    var roles_list = db.RolesHere.ToList();
                    var orders_list = db.Orders_Here.ToList();
                    var contracts_list = db.ContractsHere.ToList();


                    switch (TableSelectComboBox.SelectedIndex)
                    {
                        case 0: { databaseGrid.ItemsSource = cars_list; break; }
                        case 1: { databaseGrid.ItemsSource = cartechinfo_list; break; }
                        case 2: { databaseGrid.ItemsSource = contracts_list; break; }
                        case 3: { databaseGrid.ItemsSource = orders_list; break; }
                        case 4: { databaseGrid.ItemsSource = requirements_list; break; }
                        case 5: { databaseGrid.ItemsSource = roles_list; break; }
                        case 6: { databaseGrid.ItemsSource = users_list; break; }
                    }

                }
            }
            catch
            {
                MessageBox.Show("error");
            }
            }

       
        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {

            Data1_text.Visibility = Visibility.Visible;
            Data1_input.Visibility = Visibility.Visible;


            Add_changes_popup_button.Visibility = Visibility.Hidden;
            Save_changes_popup_button.Visibility = Visibility.Visible;
            //RemoveButton.Visibility = Visibility.Hidden;

            popup1.IsOpen = true;

            Data1_input.Text = "";
            Data2_input.Text = "";
            Data3_input.Text = "";
            Data4_input.Text = "";
            Data5_input.Text = "";
            Data6_input.Text = "";
            Data7_input.Text = "";
            Data8_input.Text = "";
            Data9_input.Text = "";
            Data10_input.Text = "";

            switch (TableSelectComboBox.SelectedIndex)
            {
                case 0:
                    {
                        Data8_input.Visibility = Visibility.Hidden;
                        Data8_text.Visibility = Visibility.Hidden;

                        Data9_input.Visibility = Visibility.Hidden;
                        Data9_text.Visibility = Visibility.Hidden;

                        Data10_input.Visibility = Visibility.Hidden;
                        Data10_text.Visibility = Visibility.Hidden;

                        Data1_text.Text = "CarID";
                        Data2_text.Text = "carModelID";
                        Data3_text.Text = "carOwnerID";
                        Data4_text.Text = "carType";
                        Data5_text.Text = "carCategory";
                        Data6_text.Text = "carDesc";
                        Data7_text.Text = "carPrice";


                        break;
                    }
                case 1:
                    {

                        Data1_text.Text = "carModelID";
                        Data2_text.Text = "carMark";
                        Data3_text.Text = "carModelName";
                        Data4_text.Text = "carComplectation";
                        Data5_text.Text = "carPower";
                        Data6_text.Text = "carGear";
                        Data7_text.Text = "carEngine";
                        Data8_text.Text = "carFuelTank";
                        Data9_text.Text = "carPlaces";
                        Data10_text.Text = "carFuelConsumption";


                        break;
                    }

                case 2:
                    {

                        Data1_text.Text = "contractID";
                        Data2_text.Text = "orderID";

                        Data3_input.Visibility = Visibility.Hidden;
                        Data3_text.Visibility = Visibility.Hidden;

                        Data4_input.Visibility = Visibility.Hidden;
                        Data4_text.Visibility = Visibility.Hidden;

                        Data5_input.Visibility = Visibility.Hidden;
                        Data5_text.Visibility = Visibility.Hidden;

                        Data6_input.Visibility = Visibility.Hidden;
                        Data6_text.Visibility = Visibility.Hidden;

                        Data7_input.Visibility = Visibility.Hidden;
                        Data7_text.Visibility = Visibility.Hidden;

                        Data8_input.Visibility = Visibility.Hidden;
                        Data8_text.Visibility = Visibility.Hidden;

                        Data9_input.Visibility = Visibility.Hidden;
                        Data9_text.Visibility = Visibility.Hidden;

                        Data10_input.Visibility = Visibility.Hidden;
                        Data10_text.Visibility = Visibility.Hidden;



                        break;
                    }

                case 3:
                    {

                        Data1_text.Text = "orderID";
                        Data2_text.Text = "managerID";
                        Data3_text.Text = "customerID";
                        Data4_text.Text = "orderStatus";
                        Data5_text.Text = "price";


                        Data6_input.Visibility = Visibility.Hidden;
                        Data6_text.Visibility = Visibility.Hidden;

                        Data7_input.Visibility = Visibility.Hidden;
                        Data7_text.Visibility = Visibility.Hidden;

                        Data8_input.Visibility = Visibility.Hidden;
                        Data8_text.Visibility = Visibility.Hidden;

                        Data9_input.Visibility = Visibility.Hidden;
                        Data9_text.Visibility = Visibility.Hidden;

                        Data10_input.Visibility = Visibility.Hidden;
                        Data10_text.Visibility = Visibility.Hidden;



                        break;
                    }
                case 4:
                    {

                        Data1_text.Text = "reqID";
                        Data2_text.Text = "customerID";
                        Data3_text.Text = "carModelID";
                        Data4_text.Text = "carCategory";
                        Data5_text.Text = "carPower";
                        Data6_text.Text = "carGear";
                        Data7_text.Text = "carEngine";
                        Data8_text.Text = "carFuelTank";
                        Data9_text.Text = "carPlaces";
                        Data10_text.Text = "Budget";


                        break;
                    }


                case 5:
                    {

                        Data1_text.Text = "roleID";
                        Data2_text.Text = "roleName";
                        Data3_text.Text = "roleDescription";



                        Data4_input.Visibility = Visibility.Hidden;
                        Data4_text.Visibility = Visibility.Hidden;

                        Data5_input.Visibility = Visibility.Hidden;
                        Data5_text.Visibility = Visibility.Hidden;

                        Data6_input.Visibility = Visibility.Hidden;
                        Data6_text.Visibility = Visibility.Hidden;

                        Data7_input.Visibility = Visibility.Hidden;
                        Data7_text.Visibility = Visibility.Hidden;

                        Data8_input.Visibility = Visibility.Hidden;
                        Data8_text.Visibility = Visibility.Hidden;

                        Data9_input.Visibility = Visibility.Hidden;
                        Data9_text.Visibility = Visibility.Hidden;

                        Data10_input.Visibility = Visibility.Hidden;
                        Data10_text.Visibility = Visibility.Hidden;



                        break;
                    }
                case 6:
                    {

                        Data1_text.Text = "userID";
                        Data2_text.Text = "userRoleID";
                        Data3_text.Text = "userName";
                        Data4_text.Text = "userEmail";
                        Data5_text.Text = "userPhone";
                        Data6_text.Text = "userlogin";
                        Data7_text.Text = "userPassword";


                        Data8_input.Visibility = Visibility.Hidden;
                        Data8_text.Visibility = Visibility.Hidden;

                        Data9_input.Visibility = Visibility.Hidden;
                        Data9_text.Visibility = Visibility.Hidden;

                        Data10_input.Visibility = Visibility.Hidden;
                        Data10_text.Visibility = Visibility.Hidden;

                        break;
                    }


            }



        }
        
      
        private void close_edit_popup_button_Click(object sender, RoutedEventArgs e)
        {
            popup1.IsOpen = false;
        }


        //*
        private void Save_changes_popup_button_Click(object sender, RoutedEventArgs e)
        {
            string id_of_field = Data1_text.Text;


            // string sqlExpression = "UPDATE Customers SET Payment_method='Cash' WHERE Customer_id=" + new_id;
            try
            {
                using (UserContext db = new UserContext())
                {

                    int i = 0;
                    string sqlExpression = "";
                    int num_obj;

                    switch (TableSelectComboBox.SelectedIndex)
                    {
                        case 0: { var data_to_update = db.CarsHere.ToList(); foreach (Cars cars in data_to_update) { if (cars.carID.ToString() == Data1_input.Text) { int ID_to_change = cars.carID; break; } i++; } MessageBox.Show(i.ToString()); data_to_update[i].carModelID = int.Parse(Data2_input.Text); data_to_update[i].carType = Data3_input.Text; data_to_update[i].carCategory = Data4_input.Text; data_to_update[i].carDesc = Data5_input.Text; break; }//data_to_update[i].carPrice = int.Parse(Data6_input.Text);  break; }
                        case 1:
                            {
                                var data_to_update = db.CarTechInfoHere.ToList();
                                for (int j = 0; j < data_to_update.Count; j++) { if (data_to_update[j].carModelID.ToString() == Data1_input.Text) { break; } i++; }
                                // MessageBox.Show(i.ToString()); 
                                data_to_update[i].carMark = Data2_input.Text;
                                data_to_update[i].carModelName = Data3_input.Text;
                                data_to_update[i].carComplectation = Data4_input.Text;
                                data_to_update[i].carPower = int.Parse(Data5_input.Text);
                                data_to_update[i].carGear = Data6_input.Text;
                                data_to_update[i].carEngine = int.Parse(Data7_input.Text);
                                data_to_update[i].carFuelTank = Data8_input.Text;
                                data_to_update[i].carPlaces = int.Parse(Data9_input.Text);
                                data_to_update[i].carFuelConsumption = int.Parse(Data10_input.Text);
                                break;
                            }
                        case 2:
                            {
                                var data_to_update = db.ContractsHere.ToList();
                                for (int j = 0; j < data_to_update.Count; j++) { if (data_to_update[j].contractID.ToString() == Data1_input.Text) { break; } i++; }
                                //MessageBox.Show(i.ToString());
                                data_to_update[i].orderID = int.Parse(Data2_input.Text);

                                break;
                            }
                        case 3:
                            {
                                var data_to_update = db.Orders_Here.ToList();
                                for (int j = 0; j < data_to_update.Count; j++) { if (data_to_update[j].orderID.ToString() == Data1_input.Text) { break; } i++; }
                                //MessageBox.Show(i.ToString());
                                data_to_update[i].managerID = int.Parse(Data2_input.Text);
                                data_to_update[i].customerID = int.Parse(Data3_input.Text);
                                data_to_update[i].orderStatus = Data4_input.Text;
                                data_to_update[i].price = int.Parse(Data5_input.Text);

                                break;
                            }
                        case 4:
                            {
                                var data_to_update = db.RequirementsHere.ToList();
                                for (int j = 0; j < data_to_update.Count; j++) { if (data_to_update[j].reqID.ToString() == Data1_input.Text) { break; } i++; }
                                //MessageBox.Show(i.ToString());
                                data_to_update[i].customerID = int.Parse(Data2_input.Text);
                                data_to_update[i].carModelID = int.Parse(Data3_input.Text);
                                data_to_update[i].carCategory = Data4_input.Text;
                                data_to_update[i].carPower = Data5_input.Text;
                                data_to_update[i].carGear = Data6_input.Text;
                                data_to_update[i].carEngine = Data7_input.Text;
                                data_to_update[i].carFuelTank = Data8_input.Text;
                                data_to_update[i].carPlaces = int.Parse(Data9_input.Text);
                                data_to_update[i].Budget = int.Parse(Data10_input.Text);
                                break;
                            }
                        case 5:
                            {
                                var data_to_update = db.RolesHere.ToList();
                                for (int j = 0; j < data_to_update.Count; j++) { if (data_to_update[j].roleID.ToString() == Data1_input.Text) { break; } i++; }
                                //MessageBox.Show(i.ToString());
                                data_to_update[i].roleName = (Data2_input.Text);
                                data_to_update[i].roleDescription = (Data3_input.Text);
                                break;
                            }
                        case 6:
                            {
                                var data_to_update = db.UsersHere.ToList();
                                for (int j = 0; j < data_to_update.Count; j++) { if (data_to_update[j].userId.ToString() == Data1_input.Text) { break; } i++; }
                                //MessageBox.Show(i.ToString());
                                data_to_update[i].userRoleId = int.Parse(Data2_input.Text);
                                data_to_update[i].userName = (Data3_input.Text);
                                data_to_update[i].userEmail = Data4_input.Text;
                                data_to_update[i].userPhone = Data5_input.Text;
                                data_to_update[i].userLogin = Data6_input.Text;
                                data_to_update[i].userPassword = Data7_input.Text;

                                break;
                            }
                    }
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Error in MainWindow-->Save_changes_popup_button_Click");
            }
            MessageBox.Show("Operation performed");
            TableSelectComboBox_SelectionChanged(TableSelectComboBox, null);  //??????
            popup1.IsOpen = false;
        }


        //?
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Data1_input.Text = "";
            Data2_input.Text = "";
            Data3_input.Text = "";
            Data4_input.Text = "";
            Data5_input.Text = "";
            Data6_input.Text = "";
            Data7_input.Text = "";
            Data8_input.Text = "";
            Data9_input.Text = "";
            Data10_input.Text = "";


            popup1.IsOpen = true;
            Data1_text.Visibility = Visibility.Hidden;
            Data1_input.Visibility = Visibility.Hidden;

            switch (TableSelectComboBox.SelectedIndex)
            {
                case 0:
                    {
                        Data8_input.Visibility = Visibility.Hidden;
                        Data8_text.Visibility = Visibility.Hidden;

                        Data9_input.Visibility = Visibility.Hidden;
                        Data9_text.Visibility = Visibility.Hidden;

                        Data10_input.Visibility = Visibility.Hidden;
                        Data10_text.Visibility = Visibility.Hidden;
                        Data1_input.Visibility = Visibility.Hidden;


                        Data1_text.Text = "CarID";
                        Data2_text.Text = "carModelID";
                        Data3_text.Text = "carOwnerID";
                        Data4_text.Text = "carType";
                        Data5_text.Text = "carCategory";
                        Data6_text.Text = "carDesc";
                        Data7_text.Text = "carPrice";


                        break;
                    }
                case 1:
                    {

                        Data1_text.Text = "carModelID";
                        Data2_text.Text = "carMark";
                        Data3_text.Text = "carModelName";
                        Data4_text.Text = "carComplectation";
                        Data5_text.Text = "carPower";
                        Data6_text.Text = "carGear";
                        Data7_text.Text = "carEngine";
                        Data8_text.Text = "carFuelTank";
                        Data9_text.Text = "carPlaces";
                        Data10_text.Text = "carFuelConsumption";


                        break;
                    }

                case 2:
                    {

                        Data1_text.Text = "contractID";
                        Data2_text.Text = "orderID";

                        Data3_input.Visibility = Visibility.Hidden;
                        Data3_text.Visibility = Visibility.Hidden;

                        Data4_input.Visibility = Visibility.Hidden;
                        Data4_text.Visibility = Visibility.Hidden;

                        Data5_input.Visibility = Visibility.Hidden;
                        Data5_text.Visibility = Visibility.Hidden;

                        Data6_input.Visibility = Visibility.Hidden;
                        Data6_text.Visibility = Visibility.Hidden;

                        Data7_input.Visibility = Visibility.Hidden;
                        Data7_text.Visibility = Visibility.Hidden;

                        Data8_input.Visibility = Visibility.Hidden;
                        Data8_text.Visibility = Visibility.Hidden;

                        Data9_input.Visibility = Visibility.Hidden;
                        Data9_text.Visibility = Visibility.Hidden;

                        Data10_input.Visibility = Visibility.Hidden;
                        Data10_text.Visibility = Visibility.Hidden;



                        break;
                    }

                case 3:
                    {

                        Data1_text.Text = "orderID";
                        Data2_text.Text = "managerID";
                        Data3_text.Text = "customerID";
                        Data4_text.Text = "orderStatus";
                        Data5_text.Text = "price";


                        Data6_input.Visibility = Visibility.Hidden;
                        Data6_text.Visibility = Visibility.Hidden;

                        Data7_input.Visibility = Visibility.Hidden;
                        Data7_text.Visibility = Visibility.Hidden;

                        Data8_input.Visibility = Visibility.Hidden;
                        Data8_text.Visibility = Visibility.Hidden;

                        Data9_input.Visibility = Visibility.Hidden;
                        Data9_text.Visibility = Visibility.Hidden;

                        Data10_input.Visibility = Visibility.Hidden;
                        Data10_text.Visibility = Visibility.Hidden;



                        break;
                    }
                case 4:
                    {

                        Data1_text.Text = "reqID";
                        Data2_text.Text = "customerID";
                        Data3_text.Text = "carModelID";
                        Data4_text.Text = "carCategory";
                        Data5_text.Text = "carPower";
                        Data6_text.Text = "carGear";
                        Data7_text.Text = "carEngine";
                        Data8_text.Text = "carFuelTank";
                        Data9_text.Text = "carPlaces";
                        Data10_text.Text = "Budget";


                        break;
                    }


                case 5:
                    {

                        Data1_text.Text = "roleID";
                        Data2_text.Text = "roleName";
                        Data3_text.Text = "roleDescription";



                        Data4_input.Visibility = Visibility.Hidden;
                        Data4_text.Visibility = Visibility.Hidden;

                        Data5_input.Visibility = Visibility.Hidden;
                        Data5_text.Visibility = Visibility.Hidden;

                        Data6_input.Visibility = Visibility.Hidden;
                        Data6_text.Visibility = Visibility.Hidden;

                        Data7_input.Visibility = Visibility.Hidden;
                        Data7_text.Visibility = Visibility.Hidden;

                        Data8_input.Visibility = Visibility.Hidden;
                        Data8_text.Visibility = Visibility.Hidden;

                        Data9_input.Visibility = Visibility.Hidden;
                        Data9_text.Visibility = Visibility.Hidden;

                        Data10_input.Visibility = Visibility.Hidden;
                        Data10_text.Visibility = Visibility.Hidden;



                        break;
                    }
                case 6:
                    {

                        Data1_text.Text = "userID";
                        Data2_text.Text = "userRoleID";
                        Data3_text.Text = "userName";
                        Data4_text.Text = "userEmail";
                        Data5_text.Text = "userPhone";
                        Data6_text.Text = "userlogin";
                        Data7_text.Text = "userPassword";


                        Data8_input.Visibility = Visibility.Hidden;
                        Data8_text.Visibility = Visibility.Hidden;

                        Data9_input.Visibility = Visibility.Hidden;
                        Data9_text.Visibility = Visibility.Hidden;

                        Data10_input.Visibility = Visibility.Hidden;
                        Data10_text.Visibility = Visibility.Hidden;

                        break;
                    }


            }

            Save_changes_popup_button.Visibility = Visibility.Hidden;
            Add_changes_popup_button.Visibility = Visibility.Visible;



            //RemoveButton.Visibility = Visibility.Hidden;
        }


        //*
        private void Add_changes_popup_button_Click(object sender, RoutedEventArgs e)
        {
            string sqlExpression = "";
            try
            {
                using (UserContext db = new UserContext())
                {




                    switch (TableSelectComboBox.SelectedIndex)
                    {
                        case 0:
                            {
                                Cars carToAdd = new Cars { carModelID = int.Parse(Data2_input.Text), carType = Data3_input.Text, carCategory = Data4_input.Text, carDesc = Data5_input.Text };// carPrice = int.Parse(Data6_input.Text)};
                                db.CarsHere.Add(carToAdd);
                                break;
                            }
                        case 1:
                            {
                                HamburgerMenuDemo.CarTechInfo carTechInfoToAdd = new HamburgerMenuDemo.CarTechInfo { carMark = Data2_input.Text, carModelName = Data3_input.Text, carComplectation = Data4_input.Text, carPower = int.Parse(Data5_input.Text), carGear = Data6_input.Text, carEngine = int.Parse(Data7_input.Text), carFuelTank = Data8_input.Text, carPlaces = int.Parse(Data9_input.Text), carFuelConsumption = int.Parse(Data10_input.Text) };

                                db.CarTechInfoHere.Add(carTechInfoToAdd);
                                break;
                            }

                        case 2:
                            {
                                HamburgerMenuDemo.Contracts contractToAdd = new HamburgerMenuDemo.Contracts { orderID = int.Parse(Data2_input.Text) };
                                db.ContractsHere.Add(contractToAdd);

                                break;
                            }


                        case 3:
                            {
                                HamburgerMenuDemo.Orders ordersToAdd = new HamburgerMenuDemo.Orders { managerID = int.Parse(Data2_input.Text), customerID = int.Parse(Data3_input.Text), orderStatus = Data4_input.Text, price = int.Parse(Data5_input.Text) };
                                db.Orders_Here.Add(ordersToAdd);
                                break;
                            }

                        case 4:
                            {
                                HamburgerMenuDemo.Requirements reqToAdd = new HamburgerMenuDemo.Requirements { customerID = int.Parse(Data2_input.Text), carModelID = int.Parse(Data3_input.Text), carCategory = Data4_input.Text, carPower = Data5_input.Text, carGear = Data6_input.Text, carEngine = Data7_input.Text, carFuelTank = Data8_input.Text, carPlaces = int.Parse(Data9_input.Text), Budget = int.Parse(Data10_input.Text) };
                                db.RequirementsHere.Add(reqToAdd);
                                break;
                            }
                        case 5:
                            {
                                HamburgerMenuDemo.Roles rolesToAdd = new HamburgerMenuDemo.Roles { roleName = Data2_input.Text, roleDescription = Data3_input.Text };
                                db.RolesHere.Add(rolesToAdd);
                                break;
                            }
                        case 6:
                            {
                                HamburgerMenuDemo.Users usersToAdd = new HamburgerMenuDemo.Users { userRoleId = int.Parse(Data2_input.Text), userName = Data3_input.Text, userEmail = Data4_input.Text, userPhone = Data5_input.Text, userLogin = Data6_input.Text, userPassword = Data7_input.Text };

                                db.UsersHere.Add(usersToAdd);
                                //sqlExpression = "INSERT INTO Users (userRoleID,userName,userEmail,userPhone,userLogin,userPassword) values ('" + Data2_input.Text + "','" + Data3_input.Text + "','" + Data4_input.Text + "','" + Data5_input.Text + "','" + Data6_input.Text + "','" + Data7_input.Text + "')";
                                break;
                            }

                    }
                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("Error in MainWindow-->Add_changes_popup_button_Click");
            }
            MessageBox.Show("Operation performed");
            TableSelectComboBox_SelectionChanged(TableSelectComboBox, null);  //??????
            popup1.IsOpen = false;

        }


        //*
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            //string sqlExpression = "";
            using (UserContext db = new UserContext()) {
                int id_to_del,i=0;
                switch (TableSelectComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            var data_to_remove = db.CarsHere.ToList();
                            foreach (Cars cars in data_to_remove) { if (cars.carID == int.Parse(toRemove.Text)) { id_to_del = i;break; } i++; }
                            db.CarsHere.Remove(data_to_remove[i]);
                            break;
                        }
                    case 1:
                        {
                            var data_to_remove = db.CarTechInfoHere.ToList();
                            foreach (HamburgerMenuDemo.CarTechInfo cars in data_to_remove) { if (cars.carModelID == int.Parse(toRemove.Text)) { id_to_del = i; break; } i++; }
                            db.CarTechInfoHere.Remove(data_to_remove[i]);
                            break;
                        }

                    case 2:
                        {
                            var data_to_remove = db.ContractsHere.ToList();
                            foreach (HamburgerMenuDemo.Contracts cars in data_to_remove) { if (cars.contractID == int.Parse(toRemove.Text)) { id_to_del = i; break; } i++; }
                            db.ContractsHere.Remove(data_to_remove[i]);
                            break;
                        }


                    case 3:
                        {
                            var data_to_remove = db.Orders_Here.ToList();
                            foreach (HamburgerMenuDemo.Orders cars in data_to_remove) { if (cars.orderID == int.Parse(toRemove.Text)) { id_to_del = i; break; } i++; }
                            db.Orders_Here.Remove(data_to_remove[i]);
                            break;
                        }

                    case 4:
                        {
                            var data_to_remove = db.RequirementsHere.ToList();
                            foreach (HamburgerMenuDemo.Requirements cars in data_to_remove) { if (cars.reqID == int.Parse(toRemove.Text)) { id_to_del = i; break; } i++; }
                            db.RequirementsHere.Remove(data_to_remove[i]);
                          
                            break;
                        }
                    case 5:
                        {
                            var data_to_remove = db.RolesHere.ToList();
                            foreach (HamburgerMenuDemo.Roles cars in data_to_remove) { if (cars.roleID == int.Parse(toRemove.Text)) { id_to_del = i; break; } i++; }
                            db.RolesHere.Remove(data_to_remove[i]); 
                            break;
                        }
                    case 6:
                        {
                            var data_to_remove = db.UsersHere.ToList();
                            foreach (HamburgerMenuDemo.Users cars in data_to_remove) { if (cars.userId == int.Parse(toRemove.Text)) { id_to_del = i; break; } i++; }
                            db.UsersHere.Remove(data_to_remove[i]); break;
                        }
                }
                db.SaveChanges();
            }

            //MessageBox.Show("Operation performed");
            /*
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                try
                {
                    int number = command.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Please enter ID to delete");
                }
            }
            */
            
            TableSelectComboBox_SelectionChanged(TableSelectComboBox, null);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (tab5_login_text.Text.IndexOf('*') != -1)
            {
                tab5_login_text.Text = CurrentUser.userLogin;   
            }
            else
            {
                tab5_login_text.Text = new String('*', CurrentUser.userLogin.Length);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (tab5_password_text.Text.IndexOf('*') != -1)
            {
                tab5_password_text.Text = CurrentUser.userPassword;
            }
            else
            {
                tab5_password_text.Text = new String('*', CurrentUser.userPassword.Length);
            }
        }

       

        //*
        private void But_find_Click(object sender, RoutedEventArgs e)
        {
            string tab_name = "";
            string tab_name_f = "";
            string id_name = "";
            int cols_num = 0;
            tab_name = search_page_combobox.SelectedIndex.ToString();
            //MessageBox.Show(tab_name);

            using (UserContext db = new UserContext())
            {
                
                //FOR MANAGER AND MAIN ADMINS  -  FULL SEARCH
                if ((CurrentUser.userRoleId == 4) || (CurrentUser.userRoleId == 5))
                {
                    
                   
                    switch (tab_name)
                    {
                        case "0":
                            {
                              
                                var data_to_find = db.CarsHere.ToList();
                                var data_to_find1 = db.CarsHere.ToList();
                                var to_output = data_to_find1;
                                to_output.Clear();  
                                foreach (Cars car in data_to_find)
                                {
                                    
                                   if (search_page_textbox.Text=="") to_output.Add(car);
                                   else if (car.carID.ToString()==search_page_textbox.Text) to_output.Add(car);
                                }
                                databaseGrid_search.ItemsSource = to_output;
                                break;
                            }
                        case "1":
                            {
                                var data_to_find = db.UsersHere.ToList();
                                var data_to_find1 = db.UsersHere.ToList();
                                var to_output = data_to_find1;
                                to_output.Clear();
                                foreach (Users car in data_to_find)
                                {
                                    if (search_page_textbox.Text == "") to_output.Add(car);
                                    else if (car.userId.ToString() == search_page_textbox.Text) to_output.Add(car);
                                }
                                databaseGrid_search.ItemsSource = to_output;
                                break;
                            }
                        case "2":
                            {
                                var data_to_find = db.Orders_Here.ToList();
                                var data_to_find1 = db.Orders_Here.ToList();
                                var to_output = data_to_find1;
                                to_output.Clear();
                                foreach (Orders car in data_to_find)
                                {
                                    if (search_page_textbox.Text == "") to_output.Add(car);
                                    else if (car.orderID.ToString() == search_page_textbox.Text) to_output.Add(car);
                                }
                                databaseGrid_search.ItemsSource = to_output;
                              
                                break;
                            }
                        case "3":
                            {
                                var data_to_find = db.RequirementsHere.ToList();
                                var data_to_find1 = db.RequirementsHere.ToList();
                                var to_output = data_to_find1;
                                to_output.Clear();
                                foreach (Requirements car in data_to_find)
                                {
                                    if (search_page_textbox.Text == "") to_output.Add(car);
                                    else if (car.reqID.ToString() == search_page_textbox.Text) to_output.Add(car);
                                }
                                databaseGrid_search.ItemsSource = to_output;

                                break;
                            }
                        case "4":
                            {
                                var data_to_find = db.RolesHere.ToList();
                                var data_to_find1 = db.RolesHere.ToList();
                                var to_output = data_to_find1;
                                to_output.Clear();
                                foreach (Roles car in data_to_find)
                                {
                                    if (search_page_textbox.Text == "") to_output.Add(car);
                                    else if (car.roleID.ToString() == search_page_textbox.Text) to_output.Add(car);
                                }
                                databaseGrid_search.ItemsSource = to_output;

                                break;
                            }


                        
                    }
                   
                }

                else if (CurrentUser.userRoleId == 2){
                    //FOR CAR BUYERS - FIND CARS INFO

                    var carstechinfo = db.CarTechInfoHere.ToList();
                    var cars_available = db.CarsHere.ToList();

                    //LIST OF CARS THAT SUIT THE SEARCH REQUEST
                    var cars_to_put_in_grid = carstechinfo;
                    cars_to_put_in_grid.Clear();
                    carstechinfo = db.CarTechInfoHere.ToList();

                    
                    foreach (CarTechInfo carTechInfo in carstechinfo)
                    {
                        foreach (Cars cars in cars_available)
                        {
                            if (carTechInfo.carModelID == cars.carModelID)   //IF THIS CAR IS ON STOCK, NOT ONLY IN WIKIPEDIA
                            {
                                string car_name_to_compare = carTechInfo.carMark + " " + carTechInfo.carModelName + " " + carTechInfo.carComplectation;
                                //MessageBox.Show(car_name_to_compare);
                                if (car_name_to_compare.IndexOf(search_page_textbox.Text, 0) != -1) { cars_to_put_in_grid.Add(carTechInfo); }

                            }
                        }
                    }
                    if (cars_to_put_in_grid.Count > 0)
                        databaseGrid_search.ItemsSource = cars_to_put_in_grid;
                    else { databaseGrid_search.ItemsSource = null; MessageBox.Show("Unfortunately there are no such cars on stock. Stay in touch for updates!"); }

                }
                else if (CurrentUser.userRoleId == 3)
                {

                    //FOR CAR OWNER ------- IF TEXT BOX EMPTY - SHOW All ORDERS WITH OWNED CARS
                    //IF TEXT BOX NOT EMPTY - SHOW ORDER WITH CHOSEN CAR
                    var requirements_list = db.RequirementsHere.ToList();
                    var users_list = db.UsersHere.ToList();
                    var to_outup = requirements_list;
                    to_outup.Clear();
                    requirements_list = db.RequirementsHere.ToList();

                    var cars_list = db.CarsHere.ToList();
                    var cars_of_currentuser = cars_list;
                    cars_of_currentuser.Clear();
                    cars_list = db.CarsHere.ToList();

                    List<BuySell> requirements_of_owner = new List<BuySell>();


                    int k = 0;

                    foreach (Requirements req in requirements_list)
                    {
                        
                        foreach (Cars car in cars_list)
                        {
                            if ((req.carID == car.carID) && (car.carOwnerID == CurrentUser.userId))
                            {
                                BuySell local = new BuySell { Buyer = "1", carID = 1, Seller = "1" };
                                //MessageBox.Show("Manager - " + req.managerID + " buyer-" + req.customerID);
                                foreach (Users users in users_list)
                                {
                                    if (users.userId == req.managerID) local.Seller = users.userName;
                                    if (users.userId == req.customerID) local.Buyer = users.userName;
                                }
                                local.carID = req.carID;


                                if (search_page_textbox.Text == "")
                                {
                                    requirements_of_owner.Add(local);
                                    k++;
                                }
                                else if (req.carID.ToString() == search_page_textbox.Text)
                                {
                                     requirements_of_owner.Add(local);
                                    k++;
                                }
                                


                                }
                        }
                        

                    }
                    if (k == 0) MessageBox.Show("There is no such data...");
                    databaseGrid_search.ItemsSource=requirements_of_owner;



                }

            }
        }
    }

}
