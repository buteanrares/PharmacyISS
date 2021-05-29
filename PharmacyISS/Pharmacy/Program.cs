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
 *      Implement account base login
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
 *          Search functionality (INFO: No LoadOrder() method is needed bcs StorageTab.Add button uploads medicine into order)
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
 *          Add real account information (username & working unit=Pharmacy)
 *          Relevant notification system
 *      
 *      STORAGE TAB:
 *          Remove medicine functionality
 *      
 *      ORDERS TAB:
 *          Add DateTimePicker for Order ETA
 *          Load order details DGV
 *      
 *      HISTORY TAB:
 *          (OPTIONAL) Add view note (VIEW ORDER NOTE @ UNITMENU.cs)
 *          
 *      ADD MEDICINE TAB:
 *          DONE!
 *          
 * DATABASE:
 *     To be implemented after all of the above are complete
 * 
 * Create requested diagrams.
 */