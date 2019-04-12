using System.Text;

namespace CollegeBookRental.Models
{
    public class IndividualButtonPartial
    {
        //I had to make properties for my buttons.
        public string ButtonType { get; set; }
        public string Action { get; set; }
        public string Glyph { get; set; }
        public string Text { get; set; }


        //I created property, for the ID for each button.
        public int? GenreId { get; set; }
        public int? BookId { get; set; }
        public int? CustomerId { get; set; }
        public int? MembershipTypeId { get; set; }

        //Return the integer the of the value being called.
        //When I add a new Id, I have to append a forward slash.
        public string ActionParameter
        {
            get
            {
                StringBuilder param = new StringBuilder(@"/");

                if (GenreId != null && GenreId > 0)
                {
                    param.Append(string.Format($"{GenreId}"));
                }
                if (BookId != null && BookId > 0)
                {
                    param.Append(string.Format($"{BookId}"));
                }
                if (CustomerId != null && CustomerId > 0)
                {
                    param.Append(string.Format($"{CustomerId}"));
                }
                if (MembershipTypeId != null && MembershipTypeId > 0)
                {
                    param.Append(string.Format($"{MembershipTypeId}"));
                }

                //This will return the parameter.
                return param.ToString();
            }
        }

    }
}