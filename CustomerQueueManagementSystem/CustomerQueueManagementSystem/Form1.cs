using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueManagementSystem
{
    public partial class Form1 : Form
    {
        private Customer aCustomer;
        Queue<Customer> myQueue = new Queue<Customer>();
       
        private int serial = 0;
            
        public Form1()
        {
            InitializeComponent();
        }

        private void enqueButton_Click(object sender, EventArgs e)
        {
            showCustomerListView.Items.Clear();
            serial++;
             string name = nameEnqueTextBox.Text;
             string complain = complainEnqueTextBox.Text;

             aCustomer = new Customer(serial,name,complain);
             myQueue.Enqueue(aCustomer);
          
            foreach (Customer showCustomers in myQueue)
            {
                ListViewItem iListView = new ListViewItem(showCustomers.SerialNo.ToString());
                iListView.SubItems.Add(showCustomers.Name);
                iListView.SubItems.Add(showCustomers.Complain);

                showCustomerListView.Items.Add(iListView);
                
            }

            
        }

        private void dequeButton_Click(object sender, EventArgs e)
        {
            showCustomerListView.Items.Clear();
            if (myQueue.Count > 0)
            {
                serialNoTextBox.Text = myQueue.Peek().SerialNo.ToString();
                nameDequeTextBox.Text = myQueue.Peek().Name;
                complainDequeTextBox.Text = myQueue.Peek().Complain;

                myQueue.Dequeue();

                // addCustomers.Add(myQueue.Peek());

                foreach (Customer showCustomers in myQueue)
                {
                    ListViewItem iListView = new ListViewItem(showCustomers.SerialNo.ToString());
                    iListView.SubItems.Add(showCustomers.Name);
                    iListView.SubItems.Add(showCustomers.Complain);

                    showCustomerListView.Items.Add(iListView);

                }
            }
            else
            {
                serial = 0;
                serialNoTextBox.Text = "";
                nameDequeTextBox.Text = "";
                complainDequeTextBox.Text = "";
                MessageBox.Show("NO Customers in your list");
            }
          }
           
        }
    }

