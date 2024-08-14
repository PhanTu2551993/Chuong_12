namespace Chuong12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Câu 1.Tóm tắt những nét cơ bản về delegate? 
                
                Delegate là cầu nối trung gian giữa sự kiện và phương thức xử lý sự kiện(method handling). 
                Delegate sẽ chứa một danh sách các phương thức sẽ ñược gọi khi sự kiện xảy ra. 
                Nó ñóng vai trò như là hàm callback(gọi xong hàm này, quay lại gọi hàm tiếp theo). 
                Một delegate có thể tham chiếu ñến nhiều phương thức và các phương thức lần lượt ñược gọi ñể thực 
                thi, tức là các phương thức ñược thực hiện một cách tuần tự.
             */

            /*
             Câu 2 : Có thể sử dụng delegate như một thuộc tính hay không? Nếu có thể thì sử dụng như thế nào?
                Cho biết ý nghĩa ?
                
                Có thể sử dụng delegate như một thuộc tính (property) trong C#. 
                Việc này cho phép bạn định nghĩa các phương thức có thể được gán vào hoặc truy xuất từ thuộc tính đó, 
                giống như cách bạn sử dụng các thuộc tính thông thường khác. 
                Delegate thuộc tính cung cấp sự linh hoạt trong việc gán và gọi các phương thức theo một cách thức có tổ chức hơn, 
                đồng thời có thể bảo vệ hoặc hạn chế việc truy cập vào các delegate

                Ý nghĩa của việc sử dụng delegate như một thuộc tính:
                    - Tính đóng gói (Encapsulation): Delegate thuộc tính giúp đóng gói logic về xử lý sự kiện hoặc hành động trong một lớp, làm cho lớp dễ dàng quản lý hơn. 
                        Người dùng lớp có thể gán hoặc thay đổi hành động mà không cần phải hiểu chi tiết về cách lớp hoạt động bên trong.

                    - Tính linh hoạt: Bằng cách sử dụng delegate thuộc tính, bạn cho phép người dùng của lớp tự do gán các phương thức khác nhau cho delegate, tùy thuộc vào nhu cầu cụ thể.

                    - Khả năng bảo vệ: Bạn có thể kiểm soát việc truy cập và thay đổi delegate thông qua thuộc tính, ví dụ như thêm logic xác thực hoặc ngăn chặn việc gán null.
             */

            /*
              Câu 3) Nếu có một số hoạt động cần được thực hiện theo một thứ tự nhất định thì ta phải làm thế nào để
                khi cần thực hiện thì gọi lần lượt thực hiện các hoạt động đó ?

                Nếu có một số hoạt động cần được thực hiện theo một thứ tự nhất định, 
                có thể sử dụng delegate để gọi các phương thức đó lần lượt theo thứ tự mong muốn. 
                Có nhiều cách để thực hiện việc này trong C#, và dưới đây là một số cách phổ biến:
                    1. Sử dụng Delegate và Multicast Delegate
                    2. Sử dụng Danh sách (List) các Delegate
                    3. Sử dụng Sự kiện (Event) và Multicast Delegate
             */

            /*
             Câu 4) Công dụng của việc khai báo delegate tĩnh? Khi nào thì nên khai báo ủy quyền tĩnh khi nào thì
            không nên ?

            - Không cần tham chiếu đối tượng: Delegate tĩnh có thể được gọi mà không cần tạo ra một thể hiện của lớp chứa delegate. 
            Điều này có thể hữu ích khi bạn chỉ cần thực thi logic mà không cần phải lưu trữ hoặc tương tác với bất kỳ trạng thái nào của đối tượng.

            - Giảm chi phí bộ nhớ: Delegate tĩnh không cần lưu trữ một tham chiếu đến đối tượng mà nó được gán vào, 
            giúp giảm chi phí bộ nhớ, đặc biệt khi delegate được sử dụng trong các ứng dụng yêu cầu hiệu suất cao.

            - Dễ sử dụng trong các tình huống toàn cục: Nếu delegate đại diện cho một hành động chung chung mà không phụ thuộc vào trạng thái của bất kỳ đối tượng nào, 
            việc khai báo delegate là tĩnh giúp bạn dễ dàng sử dụng delegate này ở bất cứ đâu trong ứng dụng.
              */

            /*
             Câu 5) Một delegate có thể gọi được nhiều hơn một phương thức hay không? Chức năng nào trong C# 
            hỗ trợ ủy quyền này ?

                Có, một delegate trong C# có thể gọi được nhiều hơn một phương thức. Chức năng hỗ trợ điều này được gọi là Multicast Delegate.

                Multicast Delegate trong C#
                Multicast delegate là một delegate có thể giữ tham chiếu đến nhiều phương thức. 
                Khi multicast delegate được gọi, tất cả các phương thức mà nó tham chiếu đến sẽ được thực thi theo thứ tự chúng được thêm vào delegate.

             */

            /*
             Câu 6) Có phải tất cả các delegate đều là delegate Multicast hay không? ðiều kiện để trở thành delegate Multicast ?
                Không phải tất cả các delegate đều là multicast delegate, nhưng hầu hết các delegate trong C# đều hỗ trợ tính năng multicast. Điều này có nghĩa là một delegate có thể giữ tham chiếu đến nhiều phương thức,
                và khi được gọi, tất cả các phương thức đó sẽ được thực thi.

                Điều kiện để trở thành multicast delegate:
                Delegate phải hỗ trợ nhiều phương thức: Delegate trong C# được thiết kế để có thể trỏ tới nhiều phương thức, do đó mặc định chúng có thể trở thành multicast delegate.

                Sử dụng toán tử += để thêm phương thức: Để một delegate trở thành multicast delegate, bạn cần sử dụng toán tử += để thêm nhiều phương thức vào delegate.
                Mỗi lần sử dụng +=, một phương thức mới sẽ được thêm vào chuỗi các phương thức mà delegate tham chiếu đến.

                Delegate phải có khả năng lưu trữ nhiều phương thức: Điều này được thực hiện thông qua một danh sách các phương thức trong delegate. Khi delegate được gọi, nó sẽ thực hiện từng phương thức theo thứ tự chúng được thêm vào.
             */

            /*
             Câu 7) Các toán tử nào có thể dùng để thực hiện việc Multicast các delegate?

                    1. Toán tử += (Addition Assignment)
                    2. Toán tử -= (Subtraction Assignment)
                    
             */
            /*
              Câu 8) Sự kiện là gì? Trong hệ thống ứng dụng nào thì sự kiện được sử dụng nhiều ?

                     Sự kiện (event) là một cơ chế cho phép một đối tượng hoặc thành phần trong chương trình thông báo cho các đối tượng khác khi một hành động cụ thể xảy ra. 
                     Sự kiện thường được sử dụng trong lập trình hướng đối tượng để thực hiện một phản ứng hoặc hành động khi có một sự thay đổi hoặc kích hoạt nào đó xảy ra.

                    Sự kiện thường gắn liền với các delegate trong C#. Khi một sự kiện xảy ra, nó sẽ kích hoạt một hoặc nhiều delegate, những delegate này sẽ gọi các phương thức được đăng ký (subscribe) để xử lý sự kiện đó.

                    Hệ thống ứng dụng nào sử dụng sự kiện : Ứng dụng giao diện người dùng (GUI - Graphical User Interface)
             */

            /*Câu 9) Những sự kiện trong C# được thực hiện thông qua cái gì?
             
            Trong C#, các sự kiện (events) được thực hiện thông qua delegate. Delegate là nền tảng cho cơ chế sự kiện trong C#, 
            cho phép bạn định nghĩa các phương thức xử lý sự kiện và liên kết chúng với các sự kiện cụ thể.
             
             */

            /*
             Câu 10) Hãy tóm lược quá trình tạo một sự kiện và giải quyết sự kiện thông qua cơ chế ủy quyền trong C#?
                1. Khai báo một Delegate
                    Delegate là một kiểu dữ liệu đặc biệt đại diện cho các phương thức có cùng chữ ký. Để bắt đầu tạo một sự kiện, bạn cần khai báo một delegate để xác định kiểu của các phương thức có thể được liên kết với sự kiện.
                2. Khai báo sự kiện (Event)
                    Sau khi khai báo delegate, sự kiện được tạo bằng cách sử dụng từ khóa event và kiểu delegate đã định nghĩa. 
                    Sự kiện này sẽ sử dụng delegate để gọi các phương thức được liên kết với nó.
                3. Kích hoạt sự kiện (Event Firing)
                    Sự kiện thường được kích hoạt (fired) từ trong một phương thức của lớp chứa sự kiện. Bạn cần viết một phương thức bảo vệ (protected) hoặc phương thức riêng tư (private) 
                    để kiểm tra và kích hoạt sự kiện nếu có bất kỳ phương thức nào đã đăng ký với sự kiện đó.
                4. Đăng ký (Subscribe) phương thức xử lý sự kiện
                    Bất kỳ đối tượng nào có thể đăng ký phương thức xử lý sự kiện vào sự kiện bằng cách sử dụng toán tử +=. Phương thức này sẽ được gọi khi sự kiện xảy ra.
                5. Hủy đăng ký (Unsubscribe) phương thức xử lý sự kiện
                    Nếu không muốn phương thức xử lý sự kiện được gọi nữa, bạn có thể hủy đăng ký nó khỏi sự kiện bằng cách sử dụng toán tử -=.
                6. Kích hoạt sự kiện khi điều kiện xảy ra
                    Cuối cùng, khi điều kiện nhất định trong chương trình xảy ra (ví dụ, một quá trình hoàn tất), bạn kích hoạt sự kiện để tất cả các phương thức đã đăng ký được thực thi.
             */
//12) Viết chương trình minh họa sử dụng ủy quyền ñể thực hiện việc chuyển các ký tự thường thành
//ký tự hoa trong một chuỗi ?
//13) Viết chương trình kết hợp giữa delegate và sự kiện ñể minh họa một ñồng hồ ñiện tử thể hiện
//giờ hiện hành trên màn hình console.
        }
    }
}
