using System;
namespace B1_Learn_Inheritance
{
    public class ChangeRequest : WorkItem
    {
        protected int originalItemID { get; set; }

        // Hàm khởi tạo. Vì không có hàm khởi tạo nào gọi tường minh
        // hàm khởi tạo của lớp cơ sở, nên hàm khởi tạo mặc định trong lớp cơ sở sẽ gọi ngầm định.
        // Lớp cơ sở phải chứa một hàm khởi tạo mặc định.

        // Hàm khởi tọa mặc định của lớp dẫn xuất.
        public ChangeRequest() { }

        // Hàm khởi tạo đối tượng có 4 tham số.
        public ChangeRequest(string title, string des, TimeSpan joblen, int originalID)
        {
            // Các thuộc tính sau và phương thức GetNextID được kế thừa từ WorkItem.
            this.ID = GetNextID();
            this.Title = title;
            this.Description = des;
            this.jobLenght = joblen;

            // Thuộc tính orginalItemID là thành viên của ChangeRequest nhưng không phải của WorkItem
            this.originalItemID = originalID;
        }
    }
}
