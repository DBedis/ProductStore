using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Provider : Concept
    {
        
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        private string password;

   

        public string Password
        {
            get { return password; }
            set
            {
                    if (value.Length > 20 || value.Length < 5)
                    {
                        System.Console.WriteLine("\n Le mot de passe doit etre entre 5 et 20 caractere."); 
                    }
                    else
                    {
                        password = value;
                    }
                
            }
        }

        private string confirmPassword;

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set 
            {
                if (!value.Equals(Password))
                {
                    System.Console.WriteLine("\n Les deux mots de passe doivent être identique");
                }
                else
                {
                    confirmPassword = value;
                }
            }
        }
        public string UserName { get; set; }
        public IList<Product> Products { get; set; }

    
        public bool Login(string username, string password, string email = null)
        {

             return ((username == this.UserName) &&
                (password == this.password) && (email != null ? this.Email == email : true));
               
        }

        public override void GetDetails()
        {
            System.Console.WriteLine("\n UserName: " + UserName + 
                "\n IsApproved: "+IsApproved
                +"\n Password: "+Password
                +"\n ConfirmPassword: "+ConfirmPassword
                +"\n Id: "+Id);
            foreach(Product P in Products)
            {
                P.GetDetails();
            };
        }

        public void GetProducts(string filterType, string filterValue)
        {
            if (this.Products != null)
            {
                switch (filterType)
                {
                    case "DATEPROD":
                        {
                            foreach (Product P in Products)
                            {
                                if (P.DateProd == DateTime.Parse(filterValue))
                                {
                                    P.GetDetails();
                                }
                            };
                            break;
                        }
                    case "Name":
                        {
                            foreach (Product P in Products)
                            {
                                if (P.Name == filterValue)
                                {
                                    P.GetDetails();
                                }
                            };
                            break;
                        }
                    case "Price":
                        {
                            foreach (Product P in Products)
                            {
                                if (P.Price == double.Parse(filterValue))
                                {
                                    P.GetDetails();
                                }
                            };
                            break;
                        }

                };

            };
        }

        public static void SetIsApproved(Provider P)
        {
            P.IsApproved = P.password == P.ConfirmPassword;
        }

        public static void SetIsApproved(string password, string confirmPassword, ref bool isApproved)
        {
            isApproved = password == confirmPassword;
        }
    }
}
