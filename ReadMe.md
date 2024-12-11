# Ehliyet Alma Projesi (Stack, Heap, ve Garbage Collection)

C# Dilinde Stack Heap ve Garbage kullanılan basit bir projedir. Stack ve Heap memory yönetiminde kullanılan yöntemlerdir.


### 1. Stack ve Heap

- **Stack**: 
    - Stack, Son çıkan değere dikkat eder.
    - Hızlıdır. Otomatik yerleştirilir.
    - `int`, `float`, `double`, `char` gibi veri türleri stack üzerinde depolanır.
    - Basit küçük programlarda kullanılır.
    - Heap'dan daha hızlıdır

- **Heap**: 
    - Heap, referans türleri (class'lar, arrays vb.) için kullanılan bellek alanıdır.
    - Daha büyük projeler için kullanılabilir.
    - Bellekte büyük yer kaplar.

### 2. Garbage Collection (Çöp Toplayıcı)

- Garbage collection (GC), heap üzerindeki kullanılmayan nesneleri otomatik olarak temizler. 
- C#'ta nesneler heap üzerinde oluşturulduğunda, bir nesne kullanılmaz hale geldiğinde, çöp toplayıcı bu nesneyi temizler. Bu işlem bellek sızıntılarını önler ve bellek yönetimini geliştirir.
- Bunlar olmazsa stack'da stack overflow, heap'da ise crashler meydama gelebilir.
- Daha kolay bir seçenek olmasını istiyorsanız değerleri null ile değiştirebilirsiniz.
  
  Kod örneğinizde, `GC.Collect()` ve `GC.WaitForPendingFinalizers()` çağrıları kullanılarak manuel garbage collection başlatılmaktadır.

### Çalıştırma:

1. Visual Studio veya Visual Studio Code gibi bir IDE kullanarak C# projelerinizi oluşturun.
2. Projeyi çalıştırarak stack ve heap üzerindeki farkları ve garbage collection'ın nasıl çalıştığını gözlemleyebilirsiniz.

