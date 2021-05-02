using System; 
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Data; 
using System.Drawing; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Windows.Forms; 
  
namespace Windowsapps { 
  
public class Form1 : Form { 
	public Form1()     
    { 
  
     	    // Creating and setting the properties of label 
        Label l = new Label(); 
        l.AutoSize = true; 
        l.Text = "Do you want to submit this project?"; 
        l.Location = new Point(222, 145); 
        l.Font = new Font("French Script MT", 18); 
        // Adding this label to form 
        this.Controls.Add(l); 
  
        // Creating and setting the properties of Button 
        Button Mybutton = new Button(); 
        Mybutton.Location = new Point(225, 198); 
        Mybutton.Text = "Submit"; 
        Mybutton.AutoSize = true; 
        Mybutton.BackColor = Color.LightBlue; 
        Mybutton.Padding = new Padding(6); 
        Mybutton.Font = new Font("French Script MT", 18); 
  
        // Adding this button to form 
        this.Controls.Add(Mybutton); 
  
        // Creating and setting the properties of Button 
        Button Mybutton1 = new Button(); 
        Mybutton1.Location = new Point(360, 198); 
        Mybutton1.Text = "Cancel"; 
        Mybutton1.AutoSize = true; 
        Mybutton1.BackColor = Color.LightPink; 
        Mybutton1.Padding = new Padding(6); 
        Mybutton1.Font = new Font("French Script MT", 18); 
  
        // Adding this button to form 
        this.Controls.Add(Mybutton1); 
    }
       	[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
} 
}
 
