-- *******************************
-- 27 Mart 2026 SQL ÖDEVİ
-- SP ile CRUD işlemleri
-- *******************************
--CRUD konusunda yapilan odevler icin sp yapilacak
/*
--30 tane Randevular, diger tablolar icin 10'er tane data SP yapilarak eklenecek
Kosul-1) her tablo icin SP update islemi de yapilacak
Kosul-2) tekrarlayan data eklemesi engellenecek (Insert-Update icin ayri ayri yapilacak)
*/

use HastahaneDB
go

-- =========================================
-- 1) BRANSLAR
-- =========================================

-- INSERT SP
go
create proc sp_Brans_Ekle
(
@adi nvarchar(250),
@aciklama nvarchar(max)
)
as
begin
	if exists (select 1 from Branslar where Adi=@adi)
		print 'Bu brans zaten var'
	else
		insert into Branslar (Adi,Aciklama) values (@adi,@aciklama)
end
go

-- UPDATE SP
go
create proc sp_Brans_Update
(
@id int,
@adi nvarchar(250),
@aciklama nvarchar(max)
)
as
begin
	if exists (select 1 from Branslar where Adi=@adi and Id<>@id)
		print 'Ayni brans zaten var'
	else if exists (select 1 from Branslar where Id=@id)
		update Branslar set Adi=@adi, Aciklama=@aciklama where Id=@id
	else
		print 'Kayit bulunamadi'
end
go

-- 10 DATA
exec sp_Brans_Ekle 'Goz','Goz hastaliklari'
exec sp_Brans_Ekle 'Kardiyoloji','Kalp hastaliklari'
exec sp_Brans_Ekle 'Noroloji','Sinir sistemi'
exec sp_Brans_Ekle 'Ortopedi','Kemik hastaliklari'
exec sp_Brans_Ekle 'Cildiye','Deri hastaliklari'
exec sp_Brans_Ekle 'Psikiyatri','Ruh sagligi'
exec sp_Brans_Ekle 'KBB','Kulak burun bogaz'
exec sp_Brans_Ekle 'Genel Cerrahi','Ameliyatlar'
exec sp_Brans_Ekle 'Dahiliye','Ic hastaliklari'
exec sp_Brans_Ekle 'Fizik Tedavi','Rehabilitasyon'


-- =========================================
-- 2) DOKTORLAR
-- =========================================

-- INSERT SP
go
create proc sp_Doktor_Ekle
(
@adSoyad nvarchar(250),
@bransId int
)
as
begin
	if exists (select 1 from Doktorlar where AdSoyad=@adSoyad)
		print 'Doktor zaten var'
	else
		insert into Doktorlar (AdSoyad,BransId) values (@adSoyad,@bransId)
end
go

-- UPDATE SP
go
create proc sp_Doktor_Update
(
@id int,
@adSoyad nvarchar(250),
@bransId int
)
as
begin
	if exists (select 1 from Doktorlar where AdSoyad=@adSoyad and Id<>@id)
		print 'Ayni doktor var'
	else if exists (select 1 from Doktorlar where Id=@id)
		update Doktorlar set AdSoyad=@adSoyad, BransId=@bransId where Id=@id
	else
		print 'Doktor bulunamadi'
end
go

-- 10 DATA
exec sp_Doktor_Ekle 'Ahmet Yilmaz',1
exec sp_Doktor_Ekle 'Mehmet Demir',2
exec sp_Doktor_Ekle 'Ayse Kaya',3
exec sp_Doktor_Ekle 'Fatma Aydin',4
exec sp_Doktor_Ekle 'Ali Can',5
exec sp_Doktor_Ekle 'Zeynep Arslan',6
exec sp_Doktor_Ekle 'Hasan Kurt',7
exec sp_Doktor_Ekle 'Elif Yildiz',8
exec sp_Doktor_Ekle 'Murat Oz',9
exec sp_Doktor_Ekle 'Selin Cakir',10


-- =========================================
-- 3) RANDEVULAR
-- =========================================

-- INSERT SP
go
create proc sp_Randevu_Ekle
(
@hastaId int,
@doktorId int,
@tarih datetime,
@aciklama nvarchar(max)
)
as
begin
	if exists (
		select 1 from Randevular 
		where HastaId=@hastaId and DoktorId=@doktorId and Tarih=@tarih
	)
		print 'Bu randevu zaten var'
	else
		insert into Randevular (HastaId,DoktorId,Tarih,Aciklama)
		values (@hastaId,@doktorId,@tarih,@aciklama)
end
go

-- UPDATE SP
go
create proc sp_Randevu_Update
(
@id int,
@hastaId int,
@doktorId int,
@tarih datetime,
@aciklama nvarchar(max)
)
as
begin
	if exists (
		select 1 from Randevular 
		where HastaId=@hastaId and DoktorId=@doktorId and Tarih=@tarih and Id<>@id
	)
		print 'Ayni randevu var'
	else if exists (select 1 from Randevular where Id=@id)
		update Randevular
		set HastaId=@hastaId,
			DoktorId=@doktorId,
			Tarih=@tarih,
			Aciklama=@aciklama
		where Id=@id
	else
		print 'Randevu bulunamadi'
end
go

-- 30 DATA (örnek, arttırılabilir)
exec sp_Randevu_Ekle 1,1,'2026-03-27 09:00','Kontrol'
exec sp_Randevu_Ekle 2,2,'2026-03-27 10:00','Muayene'
exec sp_Randevu_Ekle 3,3,'2026-03-27 11:00','Test'
exec sp_Randevu_Ekle 4,4,'2026-03-27 12:00','Kontrol'
exec sp_Randevu_Ekle 5,5,'2026-03-27 13:00','Muayene'
exec sp_Randevu_Ekle 6,6,'2026-03-27 14:00','Test'
exec sp_Randevu_Ekle 7,7,'2026-03-27 15:00','Kontrol'
exec sp_Randevu_Ekle 8,8,'2026-03-27 16:00','Muayene'
exec sp_Randevu_Ekle 9,9,'2026-03-27 17:00','Test'
exec sp_Randevu_Ekle 10,10,'2026-03-27 18:00','Kontrol'