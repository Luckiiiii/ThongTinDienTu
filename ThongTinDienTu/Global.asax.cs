﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ThongTinDienTu
{
    public class Global : System.Web.HttpApplication
    {
        /*public const string TinTuc = "TinTuc";*/

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["user"] = new List<classUser>();
            List<classUser> listUser = (List<classUser>)Application["user"];
            listUser.Add(new classUser("admin@gmail.com", "admin","admin"));
            listUser.Add(new classUser("a@gmail.com", "a","a"));
            Application["user"] = listUser;


            //1.n la Trang Dao Tao
            Application["ALL"] = new List<ThongTinTinTuc>();
            Application["DaoTao"] = new List<ThongTinTinTuc>();
            List<ThongTinTinTuc> DT = new List<ThongTinTinTuc>();
            DT.Add(new ThongTinTinTuc("1.1", "1", "Thông báo v/v Nộp hồ sơ xét tốt nghiệp đợt 1 (tháng 2 - 2022)", "1-Tổ Kế hoạch đào tạo thông báo quy trình nộp hồ sơ xét công nhận tốt nghiệp tới các sinh viên hệ Chính quy đã hoàn thành CTĐT, có đủ điều kiện xét tốt nghiệp theo quy định và có nguyện vọng được xét tốt nghiệp vào đợt 1 năm 2022 (tháng 2 - 2022), cụ thể như sau:", "Đối tượng: sinh viên tích lũy đủ điều kiện về kết quả học tập, rèn luyện (danh sách kèm theo dưới đây) 1.    Khai thông tin sinh viên qua Form dưới đây trước 10 giờ ngày 08/02/2022 2.    Hồ sơ cần nộp gồm: Đơn đăng ký tốt nghiệp (mẫu 1 theo QĐ 289 năm 2017 của VĐHMHN) Bản cam kết sinh viên (theo mẫu quy định, không cần xin chữ ký CVHT) Bằng tốt nghiệp THPT (bản photo có công chứng hoặc tương đương) Chứng chỉ Giáo dục Quốc phòng (bản photo có công chứng) Bằng tốt nghiệp THPT (bản gốc/chính để kiểm tra – đối với SV trước đây chưa được thẩm định bằng) Sinh viên cần chụp lại toàn bộ hồ sơ TN để phục vụ cập nhật thông tin xét trên hệ thống của Trường (cách thức thông báo sau) 3. Thời gian nộp hồ sơ: trong ngày 09,10/2/2022. 4. Nộp hồ sơ: Chọn 1 trong 2 cách sau (chú ý hạn nộp/dấu bưu điện theo thông báo ở trên) Trước khi nộp, SV chụp ảnh toàn bộ giấy tờ trong hồ sơ để phục vụ nộp trực tuyến cho nhà trường sau này. Qua đường bưu điện: Gửi tới Khoa Công nghệ Thông tin (96 Định Công- Thanh Xuân - Hà Nội). Áp dụng với thời gian, địa phương giãn cách. Nộp trực tiếp: Phòng 17 khu giảng đường khoa CNTT (nếu đảm bảo điều kiện phòng dịch) Lưu ý:  Để được xét công nhận tốt nghiệp, trước khi nộp hồ sơ này sinh viên phải: Tham gia và hoàn thành (đã được đánh giá đạt) các Tuần sinh hoạt Công dân – Sinh viên theo kế hoạch từng năm học. Hoàn thành các nghĩa vụ liên quan  ( tài chính, thư viện, ...) và đạt đủ các tiêu chuẩn đối với việc xét công nhận tốt nghiệp.", "FITHOU.jpg"));
            DT.Add(new ThongTinTinTuc("1.2", "1", "Thông báo Hội đồng bảo vệ luận văn tốt nghiệp Thạc sĩ năm 2021", "Thông báo Hội đồng bảo vệ luận văn tốt nghiệp Thạc sĩ năm 2021 10 / 01 / 2022 16:03 Khoa thông báo Thời gian, địa điểm và Danh sách học viên Hội đồng bảo vệ luận văn tốt nghiệp ngành CNTT năm 2021, như sau:" , "Thông báo Hội đồng bảo vệ luận văn tốt nghiệp Thạc sĩ năm 2021 10/01/2022 16:03 Khoa thông báo Thời gian, địa điểm và Danh sách học viên Hội đồng bảo vệ luận văn tốt nghiệp ngành CNTT năm 2021, như sau: Tags: Tốt nghiệp, thạc sĩ, Thời gian: Hội đồng 1: buổi Sáng ngày 15/01/2022 (từ 8h) Hội đồng 2: buổi Sáng ngày 15/01/2022 (từ 9h) Hội đồng 3: buổi Sáng ngày 15/01/2022 (từ 10h) Hội đồng 4: buổi Chiều ngày 15/01/2022 (từ 13h30) Hội đồng 5: buổi Chiều ngày 15/01/2022 (từ 14h30) Địa điểm: Khu Giảng đường Khoa Công nghệ Thông tin (96 phố Định Công, HN) Yêu cầu Trang phục: lịch sự, phù hợp với lễ bảo vệ Danh sách sinh viên và phương thức bảo vệ:", "FITHOU.jpg"));
            DT.Add(new ThongTinTinTuc("1.3", "1", "Seminar môn học An toàn và bảo mật hệ thống thông tin, khảo sát, kiểm tra tiến độ nghiên cứu khoa học của các nhóm, vạch định kế hoạch tiếp theo.", "Trong nội dung môn học “An toàn và bảo mật hệ thống thông tin” đối với học viên hệ Cao học, Bộ môn Mạng và kỹ thuật trân trọng thông báo tổ chức Seminar môn học với sự chủ trì của giảng viên chuyên môn TS. Nguyễn Đức Tuấn.", "THÔNG BÁO V/v Seminar môn học An toàn và bảo mật hệ thống thông tin -         Căn cứ theo chức năng, nhiệm vụ của Bộ môn -         Căn cứ theo lịch đào tạo năm học 2021 – 2022 hệ Cao học của Khoa CNTT -         Căn cứ theo nội dung và đề cương môn học Trong nội dung môn học “An toàn và bảo mật hệ thống thông tin” đối với học viên hệ Cao học, Bộ môn Mạng và kỹ thuật trân trọng thông báo tổ chức Seminar môn học với sự chủ trì của giảng viên chuyên môn TS. Nguyễn Đức Tuấn. ·        Thời gian: 13h30 ngày thứ  6 (25/03/2022) ·        Địa điểm: P.21, khu giảng đường Khoa CNTT, 96 Định Công, Thanh Xuân, HN ·        Báo cáo viên: Học viên cao học ·        Trân trọng kính mời các thầy, cô giảng viên Khoa CNTT và các bạn sinh viên quân tâm tham dự! Danh sách các đề tài báo cáo: 1.      Xây dựng ứng dụng quản lý mật khẩu được sử dụng trong các hệ thống của người sử dụng. Mật khẩu của người dùng được mã hoá = các thuật toán AES, DES…và so sánh 2.      Xây dựng ứng dụng nhúng tin vào ảnh số dựa trên thuật toán LSB-Matching Revisited. 3.      Xây dựng ứng dụng nhúng tin vào ảnh số dựa trên thuật toán LSB-Matching. 4.      Xây dựng ứng dụng mã hoá dữ liệu bằng RSA, RC5 và so sánh hiệu năng. 5.      Tìm hiểu về các cơ chế trao đổi khoá - key exchange algorithm và triển khai ứng dụng thực nghiệm, so sánh các cơ chế trao đổi khoá.", "FITHOU.jpg"));
            DT.Add(new ThongTinTinTuc("1.4", "1", "Seminar học phần Công nghệ lập trình tiên tiến", "Triển khai lớp học phần Công nghệ lập trình tiên tiến dành cho học viên bậc Thạc sĩ ngành CNTT, Bộ môn Công nghệ phần mềm thông báo tổ chức Seminar", "Thời gian: 14h00 ngày thứ  6, 07/01/2022. Hình thức: Online (link sẽ được mời trên goole meet) Chủ trì: giảng viên chuyên môn TS. Dương Thăng Long Báo cáo viên: Học viên cao học Danh sách các đề tài báo cáo: Phương pháp lập trình tương tác giữa các thành phần, mô-đun trong hệ thống phần mềm dựa trên Web-services với SOAP Phương pháp lập trình tương tác giữa các thành phần, mô-đun trong hệ thống phần mềm dựa trên Web-services với Rest Trân trọng kính mời các thầy, cô giảng viên Khoa CNTT tham dự! Các sinh viên Khoa CNTT quan tâm Đăng ký theo Form sau trước 13h00 ngày 07/01/2022", "FITHOU.jpg"));
            DT.Add(new ThongTinTinTuc("1.5", "1", "Thông báo v/v Đăng ký thi lại một số học phần (có đính chính)", "Khoa thông báo cho các SV đã dự thi trực tuyến kỳ vừa qua về việc cho phép đăng ký thi lại một số học phần như sau:", "Khoa thông báo cho các SV đã dự thi trực tuyến kỳ vừa qua về việc cho phép đăng ký thi lại một số học phần như sau: Tags: thông báo, Trong đợt thi trực tuyến vừa qua, các SV nếu gặp sự cố khách quan khiến cho việc thi bị gián đoạn/không làm được bài dẫn tới điểm học phần bị dưới điểm C  điểm D (đính chính theo qui chế) và có minh chứng khách quan hợp lệ cho sự cố đó, được phép đăng ký (bằng cách điền form) để Khoa xem xét cho SV thi lại học phần này. Thời gian hoàn thành việc đăng ký: trước 09:00 ngày 17/01/2022. Danh sách các môn được xét đăng ký thi lại: có trên form đăng ký Lịch thi lần 2 cho các môn được duyệt thi lại: dự kiến thứ Tư ngày 19/01/2022. SV cần chuẩn bị sẵn sàng cho việc dự thi (khi được xét duyệt) và xem lịch thi cụ thể của mình và chú ý kiểm tra thông báo từ Hội đồng thi (email) để biết các thông tin thêm (nếu có).", "FITHOU.jpg"));
            Application["DaoTao"] = DT;
            Application["ALL"] = DT;
            //2.n la Trang Tuyen Sinh
            Application["TuyenSinh"] = new List<ThongTinTinTuc>();
            List<ThongTinTinTuc> TS = new List<ThongTinTinTuc>();
            TS.Add(new ThongTinTinTuc("2.1", "2", "Thông báo v/v Nộp hồ sơ xét tốt nghiệp đợt 1 (tháng 2 - 2022)", "2-Tổ Kế hoạch đào tạo thông báo quy trình nộp hồ sơ xét công nhận tốt nghiệp tới các sinh viên hệ Chính quy đã hoàn thành CTĐT, có đủ điều kiện xét tốt nghiệp theo quy định và có nguyện vọng được xét tốt nghiệp vào đợt 1 năm 2022 (tháng 2 - 2022), cụ thể như sau:", "Đối tượng: sinh viên tích lũy đủ điều kiện về kết quả học tập, rèn luyện (danh sách kèm theo dưới đây) 1.    Khai thông tin sinh viên qua Form dưới đây trước 10 giờ ngày 08/02/2022 2.    Hồ sơ cần nộp gồm: Đơn đăng ký tốt nghiệp (mẫu 1 theo QĐ 289 năm 2017 của VĐHMHN) Bản cam kết sinh viên (theo mẫu quy định, không cần xin chữ ký CVHT) Bằng tốt nghiệp THPT (bản photo có công chứng hoặc tương đương) Chứng chỉ Giáo dục Quốc phòng (bản photo có công chứng) Bằng tốt nghiệp THPT (bản gốc/chính để kiểm tra – đối với SV trước đây chưa được thẩm định bằng) Sinh viên cần chụp lại toàn bộ hồ sơ TN để phục vụ cập nhật thông tin xét trên hệ thống của Trường (cách thức thông báo sau) 3. Thời gian nộp hồ sơ: trong ngày 09,10/2/2022. 4. Nộp hồ sơ: Chọn 1 trong 2 cách sau (chú ý hạn nộp/dấu bưu điện theo thông báo ở trên) Trước khi nộp, SV chụp ảnh toàn bộ giấy tờ trong hồ sơ để phục vụ nộp trực tuyến cho nhà trường sau này. Qua đường bưu điện: Gửi tới Khoa Công nghệ Thông tin (96 Định Công- Thanh Xuân - Hà Nội). Áp dụng với thời gian, địa phương giãn cách. Nộp trực tiếp: Phòng 17 khu giảng đường khoa CNTT (nếu đảm bảo điều kiện phòng dịch) Lưu ý:  Để được xét công nhận tốt nghiệp, trước khi nộp hồ sơ này sinh viên phải: Tham gia và hoàn thành (đã được đánh giá đạt) các Tuần sinh hoạt Công dân – Sinh viên theo kế hoạch từng năm học. Hoàn thành các nghĩa vụ liên quan  ( tài chính, thư viện, ...) và đạt đủ các tiêu chuẩn đối với việc xét công nhận tốt nghiệp.", "FITHOU.jpg"));
            TS.Add(new ThongTinTinTuc("2.2", "2", "Thông báo Hội đồng bảo vệ luận văn tốt nghiệp Thạc sĩ năm 2021", "Thông báo Hội đồng bảo vệ luận văn tốt nghiệp Thạc sĩ năm 2021 10 / 01 / 2022 16:03 Khoa thông báo Thời gian, địa điểm và Danh sách học viên Hội đồng bảo vệ luận văn tốt nghiệp ngành CNTT năm 2021, như sau:", "Thông báo Hội đồng bảo vệ luận văn tốt nghiệp Thạc sĩ năm 2021 10/01/2022 16:03 Khoa thông báo Thời gian, địa điểm và Danh sách học viên Hội đồng bảo vệ luận văn tốt nghiệp ngành CNTT năm 2021, như sau: Tags: Tốt nghiệp, thạc sĩ, Thời gian: Hội đồng 1: buổi Sáng ngày 15/01/2022 (từ 8h) Hội đồng 2: buổi Sáng ngày 15/01/2022 (từ 9h) Hội đồng 3: buổi Sáng ngày 15/01/2022 (từ 10h) Hội đồng 4: buổi Chiều ngày 15/01/2022 (từ 13h30) Hội đồng 5: buổi Chiều ngày 15/01/2022 (từ 14h30) Địa điểm: Khu Giảng đường Khoa Công nghệ Thông tin (96 phố Định Công, HN) Yêu cầu Trang phục: lịch sự, phù hợp với lễ bảo vệ Danh sách sinh viên và phương thức bảo vệ:", "FITHOU.jpg"));
            TS.Add(new ThongTinTinTuc("2.3", "2", "Seminar môn học An toàn và bảo mật hệ thống thông tin, khảo sát, kiểm tra tiến độ nghiên cứu khoa học của các nhóm, vạch định kế hoạch tiếp theo.", "Trong nội dung môn học “An toàn và bảo mật hệ thống thông tin” đối với học viên hệ Cao học, Bộ môn Mạng và kỹ thuật trân trọng thông báo tổ chức Seminar môn học với sự chủ trì của giảng viên chuyên môn TS. Nguyễn Đức Tuấn.", "THÔNG BÁO V/v Seminar môn học An toàn và bảo mật hệ thống thông tin -         Căn cứ theo chức năng, nhiệm vụ của Bộ môn -         Căn cứ theo lịch đào tạo năm học 2021 – 2022 hệ Cao học của Khoa CNTT -         Căn cứ theo nội dung và đề cương môn học Trong nội dung môn học “An toàn và bảo mật hệ thống thông tin” đối với học viên hệ Cao học, Bộ môn Mạng và kỹ thuật trân trọng thông báo tổ chức Seminar môn học với sự chủ trì của giảng viên chuyên môn TS. Nguyễn Đức Tuấn. ·        Thời gian: 13h30 ngày thứ  6 (25/03/2022) ·        Địa điểm: P.21, khu giảng đường Khoa CNTT, 96 Định Công, Thanh Xuân, HN ·        Báo cáo viên: Học viên cao học ·        Trân trọng kính mời các thầy, cô giảng viên Khoa CNTT và các bạn sinh viên quân tâm tham dự! Danh sách các đề tài báo cáo: 1.      Xây dựng ứng dụng quản lý mật khẩu được sử dụng trong các hệ thống của người sử dụng. Mật khẩu của người dùng được mã hoá = các thuật toán AES, DES…và so sánh 2.      Xây dựng ứng dụng nhúng tin vào ảnh số dựa trên thuật toán LSB-Matching Revisited. 3.      Xây dựng ứng dụng nhúng tin vào ảnh số dựa trên thuật toán LSB-Matching. 4.      Xây dựng ứng dụng mã hoá dữ liệu bằng RSA, RC5 và so sánh hiệu năng. 5.      Tìm hiểu về các cơ chế trao đổi khoá - key exchange algorithm và triển khai ứng dụng thực nghiệm, so sánh các cơ chế trao đổi khoá.", "FITHOU.jpg"));
            TS.Add(new ThongTinTinTuc("2.4", "2", "Seminar học phần Công nghệ lập trình tiên tiến", "Triển khai lớp học phần Công nghệ lập trình tiên tiến dành cho học viên bậc Thạc sĩ ngành CNTT, Bộ môn Công nghệ phần mềm thông báo tổ chức Seminar", "Thời gian: 14h00 ngày thứ  6, 07/01/2022. Hình thức: Online (link sẽ được mời trên goole meet) Chủ trì: giảng viên chuyên môn TS. Dương Thăng Long Báo cáo viên: Học viên cao học Danh sách các đề tài báo cáo: Phương pháp lập trình tương tác giữa các thành phần, mô-đun trong hệ thống phần mềm dựa trên Web-services với SOAP Phương pháp lập trình tương tác giữa các thành phần, mô-đun trong hệ thống phần mềm dựa trên Web-services với Rest Trân trọng kính mời các thầy, cô giảng viên Khoa CNTT tham dự! Các sinh viên Khoa CNTT quan tâm Đăng ký theo Form sau trước 13h00 ngày 07/01/2022", "FITHOU.jpg"));
            TS.Add(new ThongTinTinTuc("2.5", "2", "Thông báo v/v Đăng ký thi lại một số học phần (có đính chính)", "Khoa thông báo cho các SV đã dự thi trực tuyến kỳ vừa qua về việc cho phép đăng ký thi lại một số học phần như sau:", "Khoa thông báo cho các SV đã dự thi trực tuyến kỳ vừa qua về việc cho phép đăng ký thi lại một số học phần như sau: Tags: thông báo, Trong đợt thi trực tuyến vừa qua, các SV nếu gặp sự cố khách quan khiến cho việc thi bị gián đoạn/không làm được bài dẫn tới điểm học phần bị dưới điểm C  điểm D (đính chính theo qui chế) và có minh chứng khách quan hợp lệ cho sự cố đó, được phép đăng ký (bằng cách điền form) để Khoa xem xét cho SV thi lại học phần này. Thời gian hoàn thành việc đăng ký: trước 09:00 ngày 17/01/2022. Danh sách các môn được xét đăng ký thi lại: có trên form đăng ký Lịch thi lần 2 cho các môn được duyệt thi lại: dự kiến thứ Tư ngày 19/01/2022. SV cần chuẩn bị sẵn sàng cho việc dự thi (khi được xét duyệt) và xem lịch thi cụ thể của mình và chú ý kiểm tra thông báo từ Hội đồng thi (email) để biết các thông tin thêm (nếu có).", "FITHOU.jpg"));
            Application["TuyenSinh"] = TS;
            Application["ALL"] = TS;

            //3.n la trang Hoat dong
            Application["HoatDong"] = new List<ThongTinTinTuc>();
            List<ThongTinTinTuc> HD = new List<ThongTinTinTuc>();
            HD.Add(new ThongTinTinTuc("3.1", "3", "Thông báo v/v Nộp hồ sơ xét tốt nghiệp đợt 1 (tháng 2 - 2022)", "3-Tổ Kế hoạch đào tạo thông báo quy trình nộp hồ sơ xét công nhận tốt nghiệp tới các sinh viên hệ Chính quy đã hoàn thành CTĐT, có đủ điều kiện xét tốt nghiệp theo quy định và có nguyện vọng được xét tốt nghiệp vào đợt 1 năm 2022 (tháng 2 - 2022), cụ thể như sau:", "Đối tượng: sinh viên tích lũy đủ điều kiện về kết quả học tập, rèn luyện (danh sách kèm theo dưới đây) 1.    Khai thông tin sinh viên qua Form dưới đây trước 10 giờ ngày 08/02/2022 2.    Hồ sơ cần nộp gồm: Đơn đăng ký tốt nghiệp (mẫu 1 theo QĐ 289 năm 2017 của VĐHMHN) Bản cam kết sinh viên (theo mẫu quy định, không cần xin chữ ký CVHT) Bằng tốt nghiệp THPT (bản photo có công chứng hoặc tương đương) Chứng chỉ Giáo dục Quốc phòng (bản photo có công chứng) Bằng tốt nghiệp THPT (bản gốc/chính để kiểm tra – đối với SV trước đây chưa được thẩm định bằng) Sinh viên cần chụp lại toàn bộ hồ sơ TN để phục vụ cập nhật thông tin xét trên hệ thống của Trường (cách thức thông báo sau) 3. Thời gian nộp hồ sơ: trong ngày 09,10/2/2022. 4. Nộp hồ sơ: Chọn 1 trong 2 cách sau (chú ý hạn nộp/dấu bưu điện theo thông báo ở trên) Trước khi nộp, SV chụp ảnh toàn bộ giấy tờ trong hồ sơ để phục vụ nộp trực tuyến cho nhà trường sau này. Qua đường bưu điện: Gửi tới Khoa Công nghệ Thông tin (96 Định Công- Thanh Xuân - Hà Nội). Áp dụng với thời gian, địa phương giãn cách. Nộp trực tiếp: Phòng 17 khu giảng đường khoa CNTT (nếu đảm bảo điều kiện phòng dịch) Lưu ý:  Để được xét công nhận tốt nghiệp, trước khi nộp hồ sơ này sinh viên phải: Tham gia và hoàn thành (đã được đánh giá đạt) các Tuần sinh hoạt Công dân – Sinh viên theo kế hoạch từng năm học. Hoàn thành các nghĩa vụ liên quan  ( tài chính, thư viện, ...) và đạt đủ các tiêu chuẩn đối với việc xét công nhận tốt nghiệp.", "FITHOU.jpg"));
            HD.Add(new ThongTinTinTuc("3.2", "3", "Thông báo Hội đồng bảo vệ luận văn tốt nghiệp Thạc sĩ năm 2021", "Thông báo Hội đồng bảo vệ luận văn tốt nghiệp Thạc sĩ năm 2021 10 / 01 / 2022 16:03 Khoa thông báo Thời gian, địa điểm và Danh sách học viên Hội đồng bảo vệ luận văn tốt nghiệp ngành CNTT năm 2021, như sau:", "Thông báo Hội đồng bảo vệ luận văn tốt nghiệp Thạc sĩ năm 2021 10/01/2022 16:03 Khoa thông báo Thời gian, địa điểm và Danh sách học viên Hội đồng bảo vệ luận văn tốt nghiệp ngành CNTT năm 2021, như sau: Tags: Tốt nghiệp, thạc sĩ, Thời gian: Hội đồng 1: buổi Sáng ngày 15/01/2022 (từ 8h) Hội đồng 2: buổi Sáng ngày 15/01/2022 (từ 9h) Hội đồng 3: buổi Sáng ngày 15/01/2022 (từ 10h) Hội đồng 4: buổi Chiều ngày 15/01/2022 (từ 13h30) Hội đồng 5: buổi Chiều ngày 15/01/2022 (từ 14h30) Địa điểm: Khu Giảng đường Khoa Công nghệ Thông tin (96 phố Định Công, HN) Yêu cầu Trang phục: lịch sự, phù hợp với lễ bảo vệ Danh sách sinh viên và phương thức bảo vệ:", "FITHOU.jpg"));
            HD.Add(new ThongTinTinTuc("3.3", "3", "Seminar môn học An toàn và bảo mật hệ thống thông tin, khảo sát, kiểm tra tiến độ nghiên cứu khoa học của các nhóm, vạch định kế hoạch tiếp theo.", "Trong nội dung môn học “An toàn và bảo mật hệ thống thông tin” đối với học viên hệ Cao học, Bộ môn Mạng và kỹ thuật trân trọng thông báo tổ chức Seminar môn học với sự chủ trì của giảng viên chuyên môn TS. Nguyễn Đức Tuấn.", "THÔNG BÁO V/v Seminar môn học An toàn và bảo mật hệ thống thông tin -         Căn cứ theo chức năng, nhiệm vụ của Bộ môn -         Căn cứ theo lịch đào tạo năm học 2021 – 2022 hệ Cao học của Khoa CNTT -         Căn cứ theo nội dung và đề cương môn học Trong nội dung môn học “An toàn và bảo mật hệ thống thông tin” đối với học viên hệ Cao học, Bộ môn Mạng và kỹ thuật trân trọng thông báo tổ chức Seminar môn học với sự chủ trì của giảng viên chuyên môn TS. Nguyễn Đức Tuấn. ·        Thời gian: 13h30 ngày thứ  6 (25/03/2022) ·        Địa điểm: P.21, khu giảng đường Khoa CNTT, 96 Định Công, Thanh Xuân, HN ·        Báo cáo viên: Học viên cao học ·        Trân trọng kính mời các thầy, cô giảng viên Khoa CNTT và các bạn sinh viên quân tâm tham dự! Danh sách các đề tài báo cáo: 1.      Xây dựng ứng dụng quản lý mật khẩu được sử dụng trong các hệ thống của người sử dụng. Mật khẩu của người dùng được mã hoá = các thuật toán AES, DES…và so sánh 2.      Xây dựng ứng dụng nhúng tin vào ảnh số dựa trên thuật toán LSB-Matching Revisited. 3.      Xây dựng ứng dụng nhúng tin vào ảnh số dựa trên thuật toán LSB-Matching. 4.      Xây dựng ứng dụng mã hoá dữ liệu bằng RSA, RC5 và so sánh hiệu năng. 5.      Tìm hiểu về các cơ chế trao đổi khoá - key exchange algorithm và triển khai ứng dụng thực nghiệm, so sánh các cơ chế trao đổi khoá.", "FITHOU.jpg"));
            HD.Add(new ThongTinTinTuc("3.4", "3", "Seminar học phần Công nghệ lập trình tiên tiến", "Triển khai lớp học phần Công nghệ lập trình tiên tiến dành cho học viên bậc Thạc sĩ ngành CNTT, Bộ môn Công nghệ phần mềm thông báo tổ chức Seminar", "Thời gian: 14h00 ngày thứ  6, 07/01/2022. Hình thức: Online (link sẽ được mời trên goole meet) Chủ trì: giảng viên chuyên môn TS. Dương Thăng Long Báo cáo viên: Học viên cao học Danh sách các đề tài báo cáo: Phương pháp lập trình tương tác giữa các thành phần, mô-đun trong hệ thống phần mềm dựa trên Web-services với SOAP Phương pháp lập trình tương tác giữa các thành phần, mô-đun trong hệ thống phần mềm dựa trên Web-services với Rest Trân trọng kính mời các thầy, cô giảng viên Khoa CNTT tham dự! Các sinh viên Khoa CNTT quan tâm Đăng ký theo Form sau trước 13h00 ngày 07/01/2022", "FITHOU.jpg"));
            HD.Add(new ThongTinTinTuc("3.5", "3", "Thông báo v/v Đăng ký thi lại một số học phần (có đính chính)", "Khoa thông báo cho các SV đã dự thi trực tuyến kỳ vừa qua về việc cho phép đăng ký thi lại một số học phần như sau:", "Khoa thông báo cho các SV đã dự thi trực tuyến kỳ vừa qua về việc cho phép đăng ký thi lại một số học phần như sau: Tags: thông báo, Trong đợt thi trực tuyến vừa qua, các SV nếu gặp sự cố khách quan khiến cho việc thi bị gián đoạn/không làm được bài dẫn tới điểm học phần bị dưới điểm C  điểm D (đính chính theo qui chế) và có minh chứng khách quan hợp lệ cho sự cố đó, được phép đăng ký (bằng cách điền form) để Khoa xem xét cho SV thi lại học phần này. Thời gian hoàn thành việc đăng ký: trước 09:00 ngày 17/01/2022. Danh sách các môn được xét đăng ký thi lại: có trên form đăng ký Lịch thi lần 2 cho các môn được duyệt thi lại: dự kiến thứ Tư ngày 19/01/2022. SV cần chuẩn bị sẵn sàng cho việc dự thi (khi được xét duyệt) và xem lịch thi cụ thể của mình và chú ý kiểm tra thông báo từ Hội đồng thi (email) để biết các thông tin thêm (nếu có).", "FITHOU.jpg"));
            Application["HoatDong"] = HD;
            Application["ALL"] = HD;

            //4.n la trang ke hoach
            Application["KeHoach"] = new List<ThongTinTinTuc>();
            List<ThongTinTinTuc> KH = new List<ThongTinTinTuc>();
            KH.Add(new ThongTinTinTuc("4.1", "4", "Thông báo v/v Nộp hồ sơ xét tốt nghiệp đợt 1 (tháng 2 - 2022)", "4-Tổ Kế hoạch đào tạo thông báo quy trình nộp hồ sơ xét công nhận tốt nghiệp tới các sinh viên hệ Chính quy đã hoàn thành CTĐT, có đủ điều kiện xét tốt nghiệp theo quy định và có nguyện vọng được xét tốt nghiệp vào đợt 1 năm 2022 (tháng 2 - 2022), cụ thể như sau:", "Đối tượng: sinh viên tích lũy đủ điều kiện về kết quả học tập, rèn luyện (danh sách kèm theo dưới đây) 1.    Khai thông tin sinh viên qua Form dưới đây trước 10 giờ ngày 08/02/2022 2.    Hồ sơ cần nộp gồm: Đơn đăng ký tốt nghiệp (mẫu 1 theo QĐ 289 năm 2017 của VĐHMHN) Bản cam kết sinh viên (theo mẫu quy định, không cần xin chữ ký CVHT) Bằng tốt nghiệp THPT (bản photo có công chứng hoặc tương đương) Chứng chỉ Giáo dục Quốc phòng (bản photo có công chứng) Bằng tốt nghiệp THPT (bản gốc/chính để kiểm tra – đối với SV trước đây chưa được thẩm định bằng) Sinh viên cần chụp lại toàn bộ hồ sơ TN để phục vụ cập nhật thông tin xét trên hệ thống của Trường (cách thức thông báo sau) 3. Thời gian nộp hồ sơ: trong ngày 09,10/2/2022. 4. Nộp hồ sơ: Chọn 1 trong 2 cách sau (chú ý hạn nộp/dấu bưu điện theo thông báo ở trên) Trước khi nộp, SV chụp ảnh toàn bộ giấy tờ trong hồ sơ để phục vụ nộp trực tuyến cho nhà trường sau này. Qua đường bưu điện: Gửi tới Khoa Công nghệ Thông tin (96 Định Công- Thanh Xuân - Hà Nội). Áp dụng với thời gian, địa phương giãn cách. Nộp trực tiếp: Phòng 17 khu giảng đường khoa CNTT (nếu đảm bảo điều kiện phòng dịch) Lưu ý:  Để được xét công nhận tốt nghiệp, trước khi nộp hồ sơ này sinh viên phải: Tham gia và hoàn thành (đã được đánh giá đạt) các Tuần sinh hoạt Công dân – Sinh viên theo kế hoạch từng năm học. Hoàn thành các nghĩa vụ liên quan  ( tài chính, thư viện, ...) và đạt đủ các tiêu chuẩn đối với việc xét công nhận tốt nghiệp.", "FITHOU.jpg"));
            KH.Add(new ThongTinTinTuc("4.2", "4", "Thông báo Hội đồng bảo vệ luận văn tốt nghiệp Thạc sĩ năm 2021", "Thông báo Hội đồng bảo vệ luận văn tốt nghiệp Thạc sĩ năm 2021 10 / 01 / 2022 16:03 Khoa thông báo Thời gian, địa điểm và Danh sách học viên Hội đồng bảo vệ luận văn tốt nghiệp ngành CNTT năm 2021, như sau:", "Thông báo Hội đồng bảo vệ luận văn tốt nghiệp Thạc sĩ năm 2021 10/01/2022 16:03 Khoa thông báo Thời gian, địa điểm và Danh sách học viên Hội đồng bảo vệ luận văn tốt nghiệp ngành CNTT năm 2021, như sau: Tags: Tốt nghiệp, thạc sĩ, Thời gian: Hội đồng 1: buổi Sáng ngày 15/01/2022 (từ 8h) Hội đồng 2: buổi Sáng ngày 15/01/2022 (từ 9h) Hội đồng 3: buổi Sáng ngày 15/01/2022 (từ 10h) Hội đồng 4: buổi Chiều ngày 15/01/2022 (từ 13h30) Hội đồng 5: buổi Chiều ngày 15/01/2022 (từ 14h30) Địa điểm: Khu Giảng đường Khoa Công nghệ Thông tin (96 phố Định Công, HN) Yêu cầu Trang phục: lịch sự, phù hợp với lễ bảo vệ Danh sách sinh viên và phương thức bảo vệ:", "FITHOU.jpg"));
            KH.Add(new ThongTinTinTuc("4.3", "4", "Seminar môn học An toàn và bảo mật hệ thống thông tin, khảo sát, kiểm tra tiến độ nghiên cứu khoa học của các nhóm, vạch định kế hoạch tiếp theo.", "Trong nội dung môn học “An toàn và bảo mật hệ thống thông tin” đối với học viên hệ Cao học, Bộ môn Mạng và kỹ thuật trân trọng thông báo tổ chức Seminar môn học với sự chủ trì của giảng viên chuyên môn TS. Nguyễn Đức Tuấn.", "THÔNG BÁO V/v Seminar môn học An toàn và bảo mật hệ thống thông tin -         Căn cứ theo chức năng, nhiệm vụ của Bộ môn -         Căn cứ theo lịch đào tạo năm học 2021 – 2022 hệ Cao học của Khoa CNTT -         Căn cứ theo nội dung và đề cương môn học Trong nội dung môn học “An toàn và bảo mật hệ thống thông tin” đối với học viên hệ Cao học, Bộ môn Mạng và kỹ thuật trân trọng thông báo tổ chức Seminar môn học với sự chủ trì của giảng viên chuyên môn TS. Nguyễn Đức Tuấn. ·        Thời gian: 13h30 ngày thứ  6 (25/03/2022) ·        Địa điểm: P.21, khu giảng đường Khoa CNTT, 96 Định Công, Thanh Xuân, HN ·        Báo cáo viên: Học viên cao học ·        Trân trọng kính mời các thầy, cô giảng viên Khoa CNTT và các bạn sinh viên quân tâm tham dự! Danh sách các đề tài báo cáo: 1.      Xây dựng ứng dụng quản lý mật khẩu được sử dụng trong các hệ thống của người sử dụng. Mật khẩu của người dùng được mã hoá = các thuật toán AES, DES…và so sánh 2.      Xây dựng ứng dụng nhúng tin vào ảnh số dựa trên thuật toán LSB-Matching Revisited. 3.      Xây dựng ứng dụng nhúng tin vào ảnh số dựa trên thuật toán LSB-Matching. 4.      Xây dựng ứng dụng mã hoá dữ liệu bằng RSA, RC5 và so sánh hiệu năng. 5.      Tìm hiểu về các cơ chế trao đổi khoá - key exchange algorithm và triển khai ứng dụng thực nghiệm, so sánh các cơ chế trao đổi khoá.", "FITHOU.jpg"));
            KH.Add(new ThongTinTinTuc("4.4", "4", "Seminar học phần Công nghệ lập trình tiên tiến", "Triển khai lớp học phần Công nghệ lập trình tiên tiến dành cho học viên bậc Thạc sĩ ngành CNTT, Bộ môn Công nghệ phần mềm thông báo tổ chức Seminar", "Thời gian: 14h00 ngày thứ  6, 07/01/2022. Hình thức: Online (link sẽ được mời trên goole meet) Chủ trì: giảng viên chuyên môn TS. Dương Thăng Long Báo cáo viên: Học viên cao học Danh sách các đề tài báo cáo: Phương pháp lập trình tương tác giữa các thành phần, mô-đun trong hệ thống phần mềm dựa trên Web-services với SOAP Phương pháp lập trình tương tác giữa các thành phần, mô-đun trong hệ thống phần mềm dựa trên Web-services với Rest Trân trọng kính mời các thầy, cô giảng viên Khoa CNTT tham dự! Các sinh viên Khoa CNTT quan tâm Đăng ký theo Form sau trước 13h00 ngày 07/01/2022", "FITHOU.jpg"));
            KH.Add(new ThongTinTinTuc("4.5", "4", "Thông báo v/v Đăng ký thi lại một số học phần (có đính chính)", "Khoa thông báo cho các SV đã dự thi trực tuyến kỳ vừa qua về việc cho phép đăng ký thi lại một số học phần như sau:", "Khoa thông báo cho các SV đã dự thi trực tuyến kỳ vừa qua về việc cho phép đăng ký thi lại một số học phần như sau: Tags: thông báo, Trong đợt thi trực tuyến vừa qua, các SV nếu gặp sự cố khách quan khiến cho việc thi bị gián đoạn/không làm được bài dẫn tới điểm học phần bị dưới điểm C  điểm D (đính chính theo qui chế) và có minh chứng khách quan hợp lệ cho sự cố đó, được phép đăng ký (bằng cách điền form) để Khoa xem xét cho SV thi lại học phần này. Thời gian hoàn thành việc đăng ký: trước 09:00 ngày 17/01/2022. Danh sách các môn được xét đăng ký thi lại: có trên form đăng ký Lịch thi lần 2 cho các môn được duyệt thi lại: dự kiến thứ Tư ngày 19/01/2022. SV cần chuẩn bị sẵn sàng cho việc dự thi (khi được xét duyệt) và xem lịch thi cụ thể của mình và chú ý kiểm tra thông báo từ Hội đồng thi (email) để biết các thông tin thêm (nếu có).", "FITHOU.jpg"));
            Application["KeHoach"] = KH;
            Application["ALL"] = KH;

            //Application["demSoLuotXem"] = 0;
            //Application["ThongTin"] = TrangKeHoach;
            Application["SoNguoiDangTruyCap"] = 0;
            
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            /*Application.Lock();
            Application["SoNguoiDangTruyCap"] = Convert.ToInt32(Application["SoNguoiDangTruyCap"]) + 1;
            Application.UnLock();*/

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            /*Application.Lock();
            Application["SoNguoiDangTruyCap"] = Convert.ToInt32(Application["SoNguoiDangTruyCap"]) - 1;
            Application.UnLock();*/
        }

        protected void Application_End(object sender, EventArgs e)
        {
            /*Application.Lock();
            Application["SoNguoiDangTruyCap"] = Convert.ToInt32(Application["SoNguoiDangTruyCap"]) - 1;
            Application.UnLock();*/
        }
    }
}