using GestionEtudiant.back.data.repositories;
using GestionEtudiant.back.data.repositories.impl;
using GestionEtudiant.back.services;
using GestionEtudiant.back.services.impl;
using GestionEtudiant.front.views;
using GestionEtudiant.front.views.form;
using GestionEtudiant.presenter;
using GestionEtudiant.presenter.impl;

namespace GestionEtudiant
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ILoginFormView view = new LoginForm();
            IUserRepository userRepository = new UserRepository();
            IUserService userService=new UserService(userRepository);
            IFormLoginPresenter presenter = new FormLoginPresenter(view, userService) ;  
            Application.Run(view as Form);
        }
    }
}