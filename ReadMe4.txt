// Bu katman controller dan gelen i� isteklerinin koordinasyonunun y�netimini yapan katman olup bu katmandaki application sevisler ile uygulaman�n di�er katmanlar�ndaki servisler bu katman i�erisinde birbirleri ile haberle�ir

// Bu katman�n g�revi gelen i� isteklerinin kullan�m durumlar�na g�re arka planda ne t�r i�lemlerin �a��r�laca��n� koordine etmektir

//B u katmanda gelen i� iste�ine g�re input modelin do�ru olup olmad��� validasyonu, do�ru formatta ise yap�lacak olan i�lemlerin �a��r�lmas�, ilgili servis �a�r�lar�, bu operasyonlar sonras� yap�lacak i�lemler (mail at sms at bildirim g�nder vs.) sa�lanacakt�r.

// Bu katman controller i�erisine yaz�lan kodlar� temsil eden katmand�r

// Bu katman�n kullan�lmas�ndaki en b�y�k sebep uygulaman�n teknolojisinin (api teknolojisinin) de�i�mesi durumunda kodlar�m�z�n yeni teknolojiye aktar�lmas�n�n daha kolay olmas� i�in. Yani uygulama taraf�nda bir teknoloji de�i�iminde h�zl� bir migration (ge�i�) sa�layaca��z.