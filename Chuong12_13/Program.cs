namespace Chuong12_13
{

    public class Clock
    {
        // Khai báo delegate để định nghĩa kiểu của phương thức xử lý sự kiện
        public delegate void SecondChangedHandler(object sender, TimeEventArgs e);

        // Khai báo sự kiện sử dụng delegate
        public event SecondChangedHandler SecondChanged;

        // Phương thức bắt đầu đồng hồ chạy
        public void Run()
        {
            while (true)
            {
                // Lấy thời gian hiện tại
                DateTime currentTime = DateTime.Now;

                // Nếu thời gian thay đổi (tức là qua một giây)
                if (currentTime.Second != lastTime.Second)
                {
                    // Gọi sự kiện khi có sự thay đổi về giây
                    OnSecondChanged(new TimeEventArgs(currentTime));
                }

                // Cập nhật thời gian cuối cùng đã lưu
                lastTime = currentTime;

                // Dừng 100ms để không làm tốn tài nguyên CPU
                Thread.Sleep(100);
            }
        }

        // Thời gian cuối cùng đã lưu
        private DateTime lastTime;

        // Phương thức bảo vệ để kích hoạt sự kiện
        protected virtual void OnSecondChanged(TimeEventArgs e)
        {
            // Nếu có phương thức nào đã đăng ký với sự kiện, thì gọi các phương thức đó
            SecondChanged?.Invoke(this, e);
        }
    }

    // Lớp để lưu thông tin sự kiện (trong trường hợp này là thời gian hiện tại)
    public class TimeEventArgs : EventArgs
    {
        public DateTime Time { get; }

        public TimeEventArgs(DateTime time)
        {
            Time = time;
        }
    }

    public class DisplayClock
    {
        // Phương thức này sẽ được gọi khi sự kiện SecondChanged xảy ra
        public void Subscribe(Clock clock)
        {
            clock.SecondChanged += TimeHasChanged;
        }

        // Phương thức hiển thị thời gian
        private void TimeHasChanged(object sender, TimeEventArgs e)
        {
            Console.Clear();
            Console.WriteLine($"Current Time: {e.Time:HH:mm:ss}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng Clock
            Clock clock = new Clock();

            // Tạo đối tượng DisplayClock
            DisplayClock displayClock = new DisplayClock();

            // Đăng ký phương thức hiển thị với sự kiện của đồng hồ
            displayClock.Subscribe(clock);

            // Bắt đầu chạy đồng hồ
            clock.Run();
        }
    }
}
