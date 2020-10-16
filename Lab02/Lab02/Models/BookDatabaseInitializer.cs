using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab02.Models
{
    public class BookDatabaseInitializer :DropCreateDatabaseIfModelChanges<BookContext>
    {

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Chính trị – pháp luật"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Khoa học công nghệ – Kinh tế"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Văn hóa xã hội – Lịch sử"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Văn học nghệ thuật"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Truyện, tiểu thuyết"
                },
            };
            return categories;
        }
        private static List<Book> GetBooks()
        {
            var books = new List<Book>
            {
                new Book
                {
                    BookID = 1,
                    BookName = "Bộ Luật Dân Sự",
                    Description = "Cuốn sách in toàn văn Bộ luật dân sự và Nghị quyết thi hành Bộ luật dân sự được Quốc hội" +
                    " nước Cộng hòa xã hội chủ nghĩa Việt Nam" +
                    " thông qua tại kỳ họp thứ 10 Quốc hội khóa XIII và có hiệu lực thi hành từ ngày 01 tháng 01 năm 2017.",
                    ImagePath = "boluatdansu.jpg",
                    CategoryID = 1
                },
                new Book
                {
                    BookID = 2,
                    BookName = "Bộ Luật Lao Động",
                    Description = "Nội dung sách được biên soạn nguyên văn Bộ luật Lao động số 45/2019/QH14 được Quốc hội" +
                    " nước Cộng hoà xã hội chủ nghĩa Việt Nam thông qua ngày 20-11-2019 tại Kỳ họp thứ 8 khóa XIV. " +
                    "Bộ luật này có 17 Chương, 220 Điều và có hiệu lực thi hành từ ngày 01-01-2021.",
                    ImagePath = "boluatlaodong.jpg",
                    CategoryID = 1
                },
                new Book
                {
                    BookID = 3,
                    BookName = "Bộ Luật Tố Tụng Hình Sự",
                    Description = "Bộ luật tố tụng hình sự năm 2015 có kết cấu gồm 9 phần, 36 chương, 510 điều quy định trình tự, " +
                    "thủ tục tiếp nhận, giải quyết nguồn tin về tội phạm, khởi tố, điều tra, truy tố, xét xử và một số thủ tục thi hành án hình sự; nhiệm vụ,",
                    ImagePath = "totunghinhsu.jpg",
                    CategoryID = 1
                },
                new Book
                {
                    BookID = 4,
                    BookName = "Luật Doanh Nghiệp",
                    Description = "Văn bản quy phạm pháp luật quy định về việc thành lập, tổ chức quản lý, tổ chức lại, giải thể và hoạt động có liên quan của doanh nghiệp," +
                    " bao gồm công ty trách nhiệm hữu hạn, công ty cổ phần, công ty hợp danh và doanh nghiệp tư nhân; quy định về nhóm công ty.",
                    ImagePath = "luatdoanhnghiep.jpg",
                    CategoryID = 1
                },
                new Book
                {
                    BookID = 5,
                    BookName = "Luật đất đai",
                    Description = "Quyền hạn và trách nhiệm của Nhà nước đại diện chủ sở hữu toàn dân về đất đai và thống nhất quản lý về đất đai," +
                    " chế độ quản lý và sử dụng đất đai, quyền và nghĩa vụ của người sử dụng đất.",
                    ImagePath = "luatdatdai.jpg",
                    CategoryID = 1
                },
                new Book
                {
                    BookID = 6,
                    BookName = "Life 3.0",
                    Description = "Trí tuệ nhân tạo ảnh hưởng như thế nào đến công ăn việc làm, tội phạm, chiến tranh và mọi mặt của đời sống con người?",
                    ImagePath = "life3.0.jpg",
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 7,
                    BookName = "Chạy đua với Robot",
                    Description = "Nhân loại đang trải qua một cuộc cách mạng khác trong cách loài người làm việc và kiếm sống – và một lần nữa, " +
                    "cuộc cách mạng này lại đốt bỏ những điều tưởng chừng hiển nhiên của quá khứ trong đống tro tàn lịch sử",
                    ImagePath = "chayduavoirobot.jpg",
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 8,
                    BookName = "Cuộc cách mạng AI",
                    Description = "Ngày nay, sự thay đổi về công nghệ đang diễn ra với tốc độ chóng mặt và theo dự đoán, " +
                    "chỉ trong vòng hai đến ba thập niên nữa, nhân loại sẽ trải qua nhiều thay đổi hơn một nghìn năm trước đây cộng lại.",
                    ImagePath = "cuoccachmangai.jpg",
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 9,
                    BookName = "Những người tiên phong",
                    Description = "“Biệt đội” tin tặc, thiên tài và dị nhân tin học đã tạo nên cuộc cách mạng kỹ thuật số như thế nào " +
                    "Những người tiên phong là thiên sử thi kỳ vĩ về thời đại mà chúng ta đang sống – thời đại kỹ thuật số.",
                    ImagePath = "nguoitienphong.jpg",
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 10,
                    BookName = "Tôi tự hào là người Việt Nam",
                    Description = "Tôi tự hào là người Việt Nam là cuộc đấu tranh quyết liệt không bao giờ ngừng," +
                    " đòi hỏi nơi mỗi chúng ta và toàn xã hội bản lĩnh đẩy lùi cám dỗ của sự thấp hèn và lòng tham và động lực vươn lên để có thể " +
                    "tự hào là người Việt Nam.",
                    ImagePath = "tuhaovn.jpg",
                    CategoryID = 3
                },
                new Book
                {
                    BookID = 11,
                    BookName = "Lược Sử Thế Giới",
                    Description = "Từ khi được viết ra bằng tiếng Đức năm 1935, Lược sử thế giới đã trở thành cuốn sách lịch sử bán chạy ở ba mươi ngôn ngữ.",
                    ImagePath = "luocsuthegioi.jpg",
                    CategoryID = 3
                },
                new Book
                {
                    BookID = 12,
                    BookName = "Tiếng gọi nơi hoang dã",
                    Description = "Xuất bản đầu từ năm 1903, “Tiếng gọi nơi hoang dã” của Jack London đã trở thành kiệt tác thu hút bao nhiêu thế hệ người đọc." +
                    "Cuốn sách kể về những chuyến phiêu lưu mạo hiểm của chú chó Bấc (Buck)  trung thành.",
                    ImagePath = "tienggoinoihoangda.jpg",
                    CategoryID = 4
                },
                new Book
                {
                    BookID = 13,
                    BookName = "Hai số phận",
                    Description = "Hai chàng trai với hai số phận hoàn toàn trái ngược nhau. Hai đứa trẻ Kane và Anbel cùng sinh ra trong cùng một ngày, một giờ, ở hai xứ sở hoàn toàn xa lạ." +
                    " Người giàu sang, kẻ khốn khó nhưng họ đều giống nhau đến kì lạ.",
                    ImagePath = "haisophan.jpg",
                    CategoryID = 4
                },
                new Book
                {
                    BookID = 14,
                    BookName = "Nanh trắng",
                    Description = "Câu chuyện kì diệu về cuộc đời của chú chó sói lai Nanh trắng sẽ được tái hiện từ khi chú còn bé cho tới khi đến với người chủ tốt bụng Scot.",
                    ImagePath = "nanhtrang.jpg",
                    CategoryID = 4
                },
                new Book
                {
                    BookID = 15,
                    BookName = "Chuông nguyện hồn ai",
                    Description = "Là một trong những cuốn tiểu thuyết đặc sắc nhất của đại văn hào Hemingway cũng như nền văn học hiện thực Mỹ thế kỉ 20.",
                    ImagePath = "chuongnguyen.jpg",
                    CategoryID = 4
                },
                new Book
                {
                    BookID = 16,
                    BookName = "Kết giới",
                    Description = "Helena là một cô bé mồ côi được thủ lĩnh đội Vệ nhân Dmitri đem về nuôi dạy. Với tư chất thông minh, tính cách quật cường," +
                    " Helena nhanh chóng trở thành thủ lĩnh đội săn Rồng, cũng là thủ lĩnh trẻ tuổi nhất.",
                    ImagePath = "ketgioi.jpg",
                    CategoryID = 5
                },
            };
            return books;           
        }


        protected override void Seed(BookContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(b => context.Books.Add(b));
        }
    }
}