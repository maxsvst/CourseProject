using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProj
{
    public class User
    {
        public int id;
        public string login;
        public string email;
        public string password;
        private static User _applicationUser;
        public static User applicationUser
        {
            get
            {
                if (_applicationUser == null)
                    _applicationUser = new User();
                return _applicationUser;
            }
        }
        private User() { }
    }

    //----------Классы денежных опреаций----------
    class Operation
    {
        //Поля
        protected bool customDate = false;
        protected DateTime date;
        protected double sum;
        protected string comment;
        

        //Конструктор
        public Operation(double sum, string comment, bool customDate, DateTime date)
        {
            if (customDate)
            {
                this.date = date;
            }
            else 
            {
                this.date = DateTime.UtcNow;
            }
            this.sum = sum;
            this.comment = comment;
        }
    }

    class Income : Operation
    {
        //Поля
        protected string sources;

        //Конструктор
        public Income(double sum, string comment, string sourse, bool customDate, DateTime date) : base(sum, comment, customDate, date)
        {
            this.sources = sourse;
        }
    }

    class Expense : Operation
    {
        //Поля
        protected string category;

        //Конструктор
        public Expense(double sum, string comment, string category, bool customDate, DateTime date) : base(sum, comment, customDate, date)
        {
            this.category = category;
        }

    }

    class cashIncome : Income
    {
        //Конструктор
        public cashIncome(double sum, string comment, string sourse, bool customDate, DateTime date) : base(sum, comment, sourse, customDate, date)
        {

        }
    }

    class cardIncome : Income
    {
        private string cardNumber;

        //Конструктор
        public cardIncome(double sum, string comment, string sourse, string cardNumber, bool customDate, DateTime date) : base(sum,comment,sourse, customDate, date)
        {
            this.cardNumber = cardNumber;
        }
    }

    class cashExpense : Expense
    {
        //Конструктор
        public cashExpense(double sum, string comment, string category, bool customDate, DateTime date) : base(sum, comment, category, customDate, date)
        {

        }
    }

    class cardExpense : Expense
    {
        //Поля
        private string cardNumber;

        //Конструктор
        public cardExpense(double sum, string comment, string category, string cardNumber, bool customDate, DateTime date) : base(sum, comment, category, customDate, date)
        {
            this.cardNumber = cardNumber;
        }
    }

    //Кошелёк
    class Wallet
    {
        //Поля
        private double total;
        private string walletName;
        private int iconNum;
        private bool card;
        private string cardName;

        //Конструктор
        public Wallet(double total, string walletName, int iconNum, bool card, string cardName)
        {
            this.total = total;
            this.walletName = walletName;
            this.iconNum = iconNum;
            //Проверка на тип кошелька
            if (card) this.cardName = cardName;
            else this.cardName = "";
        }
    }
}
