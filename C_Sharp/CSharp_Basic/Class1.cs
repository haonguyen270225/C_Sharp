using System;

// Inheritace (Kế thừa) trong C#
// WorkItem kế thừa mặc định từ lớp Object;
public class WorkItem
{
    // Trường tĩnh currentID lưu trữ ID của WorkItem được tạo cuối cùng.
    private static int currentID;

    // Các thuộc tính;
    protected int ID { get; set; }
    protected string Title { get; set; }
    protected string Description { get; set; }
    protected TimeSpan jobLenght { get; set; }

    // constructure mặc định. Nếu  một lớp dẫn xuất không gọi tường minh
    // hàm khởi tạo của lớp cơ sở, thì hàm khởi tạo mặc định sẽ được gọi một cách ngầm định.

    public WorkItem()
    {
        ID = 0;
        Title = "Default title";
        Description = "Default description";
        jobLenght = new TimeSpan();
    }

    // Hàm khởi tạo đối tượng có 3 tham số;
    public WorkItem(string title, string desc, TimeSpan joblen)
    {
        ID = GetNextID();
        Title = title;
        Description = desc;
        jobLenght = joblen;
    }
    // Hàm khởi tạo tĩnh để khởi tạo thành viên tĩnh currentID
    // Hàm khởi tạo này được gọi tự động một lần, trước khi bất kỳ đối tượng nào của WorkItem hoặc ChangeRequest được tạo ra
    // hoặc trước khi currentID được tham chiếu.
    static WorkItem() => currentID = 0;

    // currentID là một trường tĩnh. Nó được tăng lên mỗi khi một thể hiện (instance) mới
    // của WorkItem được tạo ra.
    protected int GetNextID() => ++currentID;

    // Phương thức Update cho phép bạn cập nhật tiêu đề và thời lượng công việc
    // của một đối tượng WorkItem đã tồn tại.
    public void Update(string title, TimeSpan joblen)
    {
        this.Title = title;
        this.jobLenght = joblen;
    }

    //  Phương thức ảo ghi đề (override) phương thức ToString
    // được kế thừa từ System.Object;
    public override string ToString() => $"{this.ID} - {this.Title}";
}

// ChangeRequest Kế thừa từ Workitem và bổ sung một thuộc tính 
// (originalItemID) cùng hai hàm khởi tạo.

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