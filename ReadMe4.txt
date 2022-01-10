// Bu katman controller dan gelen iþ isteklerinin koordinasyonunun yönetimini yapan katman olup bu katmandaki application sevisler ile uygulamanýn diðer katmanlarýndaki servisler bu katman içerisinde birbirleri ile haberleþir

// Bu katmanýn görevi gelen iþ isteklerinin kullaným durumlarýna göre arka planda ne tür iþlemlerin çaðýrýlacaðýný koordine etmektir

//B u katmanda gelen iþ isteðine göre input modelin doðru olup olmadýðý validasyonu, doðru formatta ise yapýlacak olan iþlemlerin çaðýrýlmasý, ilgili servis çaðrýlarý, bu operasyonlar sonrasý yapýlacak iþlemler (mail at sms at bildirim gönder vs.) saðlanacaktýr.

// Bu katman controller içerisine yazýlan kodlarý temsil eden katmandýr

// Bu katmanýn kullanýlmasýndaki en büyük sebep uygulamanýn teknolojisinin (api teknolojisinin) deðiþmesi durumunda kodlarýmýzýn yeni teknolojiye aktarýlmasýnýn daha kolay olmasý için. Yani uygulama tarafýnda bir teknoloji deðiþiminde hýzlý bir migration (geçiþ) saðlayacaðýz.