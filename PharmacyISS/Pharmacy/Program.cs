using Pharmacy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}


/* TODO LIST:
 * 
 * Login.cs:
 *      Implement account based login
 *      Add a Create account form
 *      (OPTIONAL) Add Forgot passowrd form (email based)
 *      
 *      
 * UnitMenu.cs:
 *      HOME TAB:
 *          Add real account information (username & working unit) (DONE)
 *          Relevant notification system
 *          
 *      STORAGE TAB:
 *          Add button functionality (DONE)
 *          Search functionality (DONE)
 *          Datagridview functionality (DONE)
 *      
 *      ORDER TAB:
 *          Search functionality (INFO: No LoadOrder() method is needed bcs StorageTab.Add button uploads medicine into orderDGV)
 *          Remove medicine functionality (DONE)
 *          Datagridview functionality (DONE - made by StorageTab.Add button)
 *          Place order functionality (DONE)
 *      
 *      CONFIRMATIONS TAB:
 *          Search functionality (DONE)
 *          Confirm order arrival functionality (DONE)
 *          Datagridview functionality (DONE)
 *          
 * PharmacyMenu.cs:
 *      HOME TAB:
 *          Add real account information (username & working unit=Pharmacy) (DONE)
 *          Relevant notification system
 *      
 *      STORAGE TAB:
 *          Remove medicine functionality (DONE)
 *      
 *      ORDERS TAB:
 *          Add DateTimePicker for Order ETA (DONE)
 *          Load order details DGV (DONE)
 *      
 *      HISTORY TAB:
 *          (OPTIONAL) Add view note (VIEW ORDER NOTE @ UNITMENU.cs)
 *          
 *      ADD MEDICINE TAB:
 *          DONE!
 *          
 * DATABASE:
 *     To be implemented after all of the above are complete
 *     Implement OrderedMedicine table for Order.cs' List<Medicine> medicine field. (X)
 *     Many to many relationship
 * 
 * Create requested diagrams.
 */