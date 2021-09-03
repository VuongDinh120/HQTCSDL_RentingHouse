USE QLTN
GO

INSERT INTO districts(name)
VALUES (N'Tân Phú'),(N'Q.1'),(N'Q.5'),(N'Thủ Đức'),(N'Tân Bình')
GO

INSERT INTO roles(r_type)
VALUES (N'Khách Hàng'),(N'NV Khảo sát'),(N'Admin')
GO

INSERT INTO users(username, u_password, fullname, dob, phone, id_card, account_balance, role_id)
VALUES (N'user01', '123456', N'Phí Nhật Linh', '1993-01-28', '2132234116','0399512108', 150, 1),
		(N'user02', '123456', N'Phan Trúc Phương', '1994-04-06', '9305394601','7098493200', 550, 1),
		(N'user03', '123456', N'Nguyễn Thu Liên', '1995-12-12', '4359814738','7286382187', 850, 1),
		(N'staff01', '123456', N'Trần Thiên Trang', '1997-05-02', '5332401206','8715007496', 850, 2),
		(N'admin01', '123456', N'Đặng Hồng Thảo', '1998-03-27', '6644593428','0603500726', 850, 3)
GO

INSERT INTO fees(name, price)
VALUES (N'Phi trach nhiem', 1000),(N'Phi thue', 2000),(N'Phi gioi thieu', 3000)
GO

INSERT INTO transactions(t_money, t_fee_id, t_user_id)
VALUES (1000, 2, 1),(2000, 1, 2),(500, 3, 3), (1500, 3, 4), (3000, 1, 5)
GO

INSERT INTO booking(begin_date, end_date, b_status, number_house, rent_fee, liability_fee, b_user_id)
VALUES ('2021-04-18','2022-03-18', N'Huỷ đơn', 1, 1000, 500, 1),
		('2021-05-29','2022-07-26', N'Đơn quá hạn', 3, 2000, 500, 2),
		('2021-06-22','2025-07-18', N'Thuê thành công', 1, 3000, 500, 3),
		('2021-08-08','2025-09-11', N'Thuê thành công', 2, 500, 500, 1),
		('2021-12-05','2025-09-29', N'Thuê thành công', 4, 350, 500, 2)
GO


INSERT INTO houses(area, rental, number_people, h_address, h_description, h_status, district_id, h_user_id)
VALUES (150.15, 1000, 10, N'766 Phố Bảo Hương Vy', N'Một nhà bếp trung bình và hai phòng tắm, ba phòng ngủ',N'Sẵn sàng', 1, 2),
		(450.15, 2000, 8, N'971 Phố Thạch Minh Đôn', N'Một nhà bếp lớn và hai phòng tắm và một nhà kho lớn',N'Đang được thuê', 3, 1),
		(200.15, 3000, 2, N'20 Phố Cái Du Việt, Phường Đường Sinh Khiếu', N'Một nhà bếp kiểu cũ và hai phòng tắm, ba phòng ngủ',N'Sẵn sàng', 2, 3),
		(70.60, 2000, 5, N'72 Phố Chung Thiên Sâm', N'Một nhà bếp nhỏ và một phòng tắm lớn',N'Đang được thuê', 5, 2),
		(147.22, 1000, 3, N'144, Thôn Diệu Thập', N'Một nhà bếp hiện đại và ba phòng tắm',N'Sẵn sàng', 4, 1),
		(155.30, 1000, 3, N'165, Thôn Bắc', N'Một nhà bếp hiện đại và ba phòng tắm',N'pending', 4, 1),
		(175.80, 1500, 3, N'167, Thôn Nam', N'Một nhà bếp hiện đại và ba phòng tắm',N'pending', 4, 2),
		(157.30, 1000, 8, N'12, Thôn Tây', N'Một nhà bếp hiện đại và ba phòng tắm',N'pending', 2, 1)
GO


INSERT INTO booking_detail(booking_id, house_id, meet_time, meet_address, meet_phone, is_rented)
VALUES (1,1,'2021-01-26', N'766 Phố Bảo Hương Vy', '7134233872', 1),
		(1,2,'2021-02-18', N'971 Phố Thạch Minh Đôn', '8164162290', 1),
		(1,3,'2021-03-09', N'20 Phố Cái Du Việt', '8013745927', 0),
		(2,4,'2021-03-14', N'72 Phố Chung Thiên Sâm', '5593007349', 0),
		(2,5,'2021-04-19', N'144, Thôn Diệu Thập', '4064282444', 1),
		(2,2,'2021-06-24', N'971 Phố Thạch Minh Đôn', '8164162290', 1),
		(3,4,'2021-07-09', N'72 Phố Chung Thiên Sâm', '5593007349', 0),
		(3,2,'2021-07-11', N'971 Phố Thạch Minh Đôn', '8164162290', 1),
		(3,3,'2021-07-14', N'20 Phố Cái Du Việt', '8013745927', 0),
		(4,1,'2021-08-20', N'766 Phố Bảo Hương Vy', '7134233872', 1),
		(4,5,'2021-11-27', N'144, Thôn Diệu Thập', '4064282444', 0),
		(5,3,'2021-12-02', N'20 Phố Cái Du Việt', '8013745927', 0),
		(5,4,'2021-12-31', N'72 Phố Chung Thiên Sâm', '5593007349', 1)
GO

INSERT INTO surveys(detail, s_status, house_id, s_user_id)
VALUES (N'Mái bằng, lợp ngói xám. Hai ống khói nhỏ đặt ở hai bên của ngôi nhà. Cửa sổ giếng trời',N'Đạt yêu cầu', 1, 1),
		(N'Tòa nhà có dạng hình tròn. Ngôi nhà được bao quanh hoàn toàn bởi sân', N'Không đạt', 2, 2),
		(N'Từ bên ngoài ngôi nhà này trông ấm cúng và thoải mái. Nó được xây dựng bằng gỗ sồi',N'Đạt yêu cầu', 3, 3),
		(N'Một khu vườn được chăm sóc cẩn thận, với một cánh đồng cỏ và những mảng hoa ở rìa khu vườn',N'Đạt yêu cầu', 4, 1),
		(N'Một số cửa sổ lớn mang lại nhiều ánh sáng cho các phòng bên dưới mái nhà',N'Đạt yêu cầu', 5, 2)
GO

INSERT INTO contracts(house_id, c_order, begin_date, end_date, fee)
VALUES (1, 2,'2021-04-18','2022-03-18', 500),
		(3, 1,'2021-05-29','2022-07-26', 2000),
		(1, 1,'2021-06-22','2025-07-18', 3000),
		(2, 1,'2021-08-08','2025-09-11', 500),
		(4, 1,'2021-12-05','2025-09-29', 350)
GO