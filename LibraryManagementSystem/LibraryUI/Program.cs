using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ClassLibrary.GlobalConfig.InitializeDataConnection(ClassLibrary.Enums.textFile);

            SignInForm signInForm = new SignInForm();
            Application.Run(signInForm);

            UserForm userForm = new UserForm();
            userForm.LoggedUser = signInForm.LoggedUser;
            Application.Run(userForm);
        }
    }
}
