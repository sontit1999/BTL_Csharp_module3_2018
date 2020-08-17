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
select * from Tickets where ID = 4279 and CabinTypeID = 2
delete from Tickets where ID = 4279

select count(*) from Tickets where ScheduleID = 31 and CabinTypeID = 3
select * from Aircrafts where ID = ( select Schedules.AircraftID from Schedules where ID = 31 )

select BookingReference from Tickets 
group by BookingReference

-- insert 1 vé :
insert into Tickets values
(null,1,11,1,'firstname','lastname',null,'0335275320','14111111',145,'XXXXXX',1)

select ID from Countries where Name = 'Canada'