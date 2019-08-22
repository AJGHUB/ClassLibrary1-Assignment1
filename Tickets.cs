using System;

namespace ClassLibrary1
{
    public class Tickets
    {
        public int quantity;
        public string day;
        public int time;
        public double adult_before_5_price;
        public double adult_after_5_price;
        public double adult_tuesday_price;
        public double child_price;
        public double senior_price;
        public double student_price;
        public double family_pass_price;
        public double chick_flick_thurs_price;
        public double kids_carers_wed_price;
        public double total_price;



        public double Adult_Before_5(int quantity, string person, string day, int time)//equivalance set
        {
            this.adult_before_5_price = 14.5; // this. = this is referencing to inside the class 'Tickets'
            if (day == "daily" && person == "adult" && quantity > 0 && time < 1800)
                this.total_price = adult_before_5_price * quantity;
            return this.total_price;
        }

        public double Adult_After_5(int quantity, string person, string day, int time)
        {
            adult_after_5_price = 17.5;
            if (day == "daily" && person == "adult" && quantity > 0 && time > 1800)
                this.total_price = adult_after_5_price * quantity;
            return this.total_price;
        }

        public double Adult_Tuesday(int quantity, string person, string day)
        {
            adult_tuesday_price = 13;
            if (quantity > 0 && person == "adult" && day == "tuesday")
                this.total_price = adult_tuesday_price * quantity;
            return this.total_price;
        }

        public double Child(int quantity, string person, string day)
        {
            child_price = 12;
            if (day == "daily" && person == "child" && quantity > 0)
                this.total_price = child_price * quantity;
            return this.total_price;
        }

        public double Senior(int quantity, string person, string day)
        {
            senior_price = 12.5;
            if (day == "daily" && person == "senior" && quantity > 0)
                this.total_price = senior_price * quantity;
            return this.total_price;
        }

        public double Student(int quantity, string person, string day)
        {
            student_price = 14;
            if (day == "daily" && person == "student" && quantity > 0)
                this.total_price = student_price * quantity;
            return this.total_price;
        }

        public double Family_Pass(int quantity_parent, int quantity_child, string day)
        {
            family_pass_price = 46;
            if (day == "daily" && quantity_parent >= 4 && quantity_child >=3)
                this.total_price = family_pass_price * quantity;
            return this.total_price;
        }

        public double Chick_Flick_Thursday(int quantity, string person, string day)
        {
            chick_flick_thurs_price = 21.5;
            if (day == "wednesday holidays" && person == "chickflick" && quantity > 0)
                this.total_price = chick_flick_thurs_price * quantity;
            return this.total_price;
        }


        public double Kids_Carers_Wednesday(int quantity, string person, string day)
        {
            kids_carers_wed_price = 21;
            if (day == "wednesday" && person == "adult" && quantity > 0)
                this.total_price = kids_carers_wed_price * quantity;
            return this.total_price;
        }
    }
}
