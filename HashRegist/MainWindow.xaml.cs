using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

namespace HashRegist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //string rootpath;
        public MainWindow()
        {
            InitializeComponent();
        //    rootpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
        //    rootpath = rootpath + "//Sathish";
        //    if (!Directory.Exists(rootpath))
        //    {
        //        Directory.CreateDirectory(rootpath);
        //    }
        }
        Stack stack;
        Queue queue;
        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            listbox.Items.Add(txtname.Text);
            listbox.Items.Add(txtpassword.Text);
            listbox.Items.Add(txtage.Text);
            listbox.Items.Add(txtcontact.Text);
            listbox.Items.Add(txtemail.Text);
            listbox.Items.Add(txtaddress.Text);
            listbox.ItemsSource = null;
            listbox.ItemsSource = (listbox.ToString());
            //string path = $"C:\\Users\\vijay\\AppData\\Roaming//Sathish\\{txtname.Text}.txt";
            //string content =$"{ txtname.Text }|{ txtpassword.Text}";
            //if(!File.Exists(path))
            //{
            //  File.WriteAllText(path, content);
            //    MessageBox.Show("Register success");
            //}

            stack = new Stack();
            stack.Push(listbox);
            txtbstack.Text = stack.Peek().ToString();


            queue = new Queue();
            queue.Enqueue(listbox);
            txtbque.Text = queue.Peek().ToString();

            //List<string> list = new List<string>();
            //list.Add(path);

            //    Hashtable hash= new Hashtable();            
            //    hash.Add("Name", txtname.Text);
            //    hash.Add("Password", txtpassword.Text);
            //    hash.Add("Contact", txtcontact.Text);
            //    hash.Add("Age", txtage.Text);
            //    hash.Add("Email", txtemail.Text);
            //    hash.Add("Address", txtaddress.Text);

            //    foreach (DictionaryEntry item in hash)
            //    {
            //        cmbhash.Items.Add(item.Value.ToString());
            //    }


            //    Stack stack = new Stack();
            //    stack.Push(txtname.Text);
            //    stack.Push(txtpassword.Text);
            //    stack.Push(txtcontact.Text);
            //    stack.Push(txtage.Text);
            //    stack.Push(txtemail.Text);
            //    stack.Push(txtaddress.Text);
            //    txtbstack.Text =stack.Peek().ToString();

            //    Queue queue = new Queue();
            //    queue.Enqueue(txtname.Text);
            //    queue.Enqueue(txtpassword.Text);
            //    queue.Enqueue(txtcontact.Text);   
            //    queue.Enqueue(txtage.Text);
            //    queue.Enqueue(txtemail.Text);
            //    queue.Enqueue(txtaddress.Text);
            //    txtbque.Text = queue.Peek().ToString();
        }
    }
    }











