select * from CabinTypes
select * from Roles
select * from Aircrafts
select * from Routes
select * from Countries
select * from Users
select * from Schedules
select * from Offices
select * from Tickets


-- cabin_type : loại cabin
-- roles: loại người dùng: admin/user 
-- Aircrafts: máy bay: 
-- Route: lộ trình
-- country: quốc gia
-- user: người dùng
-- schedule: lịch trình
-- office: văn phòng
-- Ticket: vé
-- airport: sân bay

select * from Schedules inner join Routes 
on Schedules.RouteID = Routes.ID
where Routes.DepartureAirportID = 2 and Routes.ArrivalAirportID = 4

select * from Airports