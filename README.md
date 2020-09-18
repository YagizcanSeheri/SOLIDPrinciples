# SOLID Principles
1.) **Single Responsibility Principle** <br/>

-Bir sınıf, method sadece bir işi yapmalıdır.<br/> 
-Bir sınıfın değişmesi için sadece bir nedeni olmalıdır. Yani bir sınıfın yanlızca bir işi olmalıdır.<br/>
-Örneğin, işe yeni başlamış personelin özlük bilgilerinin sisteme kaydedilmesi, bu işlemin loglarının tutulması ve ilgili kişi sisteme kayıt olduğunda müdürüne bilgilendirme e-postası gönderecek basit bir uygulamamız olduğunu düşünelim. Bu işlemleri tek bir sınıf içerisinde yerine getirebiliriz. Bu işlemi bu şekilde yaparsak bu prensibe ters düşmüş oluruz. Bu prensibe uymak için tüm bu işlemleri ayrı sınıflarda ele alamamız gerekmektedir. Her sınıfın sadece bir sorumluluğu olmalıdır. Örneğin, loglama işlemi için bir sınıfın, çalışanı veri tabanına kaydetmek için bir sınıf ve bilgilendirme e-postası için bir sınıf kullanılımalıdır.

[-SRP Examples](https://github.com/YagizcanSeheri/SOLIDPrinciples/tree/master/SOLIDPrinciples/Single%20Responsibilty%20Principle)<br/>

2.) **Open & Close Principle** <br/>

-Uygulamalar geliştirilmeye açık fakat değişime kapalı olmalıdır.<br/>
-Her yeni sınıf oluşturmak istediğimizde , bu oluşturmak istediğimiz sınıfı rahat bir şekilde oluşturmak isteriz.Zaten OOP genişletilebilirliği destekler.Lakin bu genişleme esnasında yaratılan sınıflarda modifikasyona gerek kalmayacak şekilde mimariyi kurmak gerekmektedir. 
-Örneğin basit bir coffeshop uygulaması düşünelim, bu uygulamada bir coffe sınıfım ve coffee type'Larını tutacak enum var. Her yeni bir kahve türü geldiğinde enum'a kahve türünü ekliyoruz. Coffe sınıfında ise if-else yapılarıyla ilgli kahve türlerine göre içilen kahve birim fiyatına ve miktarına göre ücret hesabı yapıyor.Ama bu senaryodaki mimari bu prensibe ters düşmektedir. Bu prensibe uymak istersek soyut bir sınıfa methot tanımlayarak bu methodu her bir kahve için açacağımız sınıfta override ederek kullanmalıyız. Böylelikle her kahve için var olan sınıflarımda bir değişikliğe gitmemiş olacağım.Soyut sınıf yardımıyla kural koyarak alt sınıflarımızı değişeme kapalı tutmuş olduk. 

[-OCP Examples](https://github.com/YagizcanSeheri/SOLIDPrinciples/tree/master/SOLIDPrinciples/Open%20Close%20Principle)<br/>

3.) **Liskov Substitution Principle** <br/>

-*Alt sınıflardan oluşan nesnelerin üst sınıfın nesneleri ile yer değiştirdikleri zaman, aynı davranışı sergilemesini beklemektedir öyle ki alt sınıflarda oluşan nesneler üst sınıflardan oluşan nesneler ile yer değiştirilebilir olmalıdır.*<br/>

[-LSP Examples](https://github.com/YagizcanSeheri/SOLIDPrinciples/tree/master/SOLIDPrinciples/Liskov%20Subtution%20Principle)<br/>

4.) **Interface Segregation Principle** <br/>

-Interfacelerin doğru parçalara ayrılmasıdır yani sınıflar ihtiyaçları olmayan özellikleri ve davranışları içeren interfacelerden implement edilmemelidir.<br/>
-Örneğin, karenin ve dikdörtgenin alanını hesaplayan basit bir uygulamamız olsun. Bir dikdörtgen sınıf oluşturarak bu sınıfa 2 member veriyoruz. Yüksekllik ve uzunluk, fakat kare geometrik şekili için bu ata sınıf çokta uygun olmamaktadır. Yani dikdörtgen sınıfından kalıtım alan bir kare sınıfından nesne oluşturmaya kalkarsak ata sınıfların mantığından ve amacından şaşmış oluyoruz ve bu prensibe ters düşmüş oluyoruz. Bu hatayı düzeltmek için dörtgen yapısnın ortak özelliklerini barındıracak bir sınıf oluşturulmalı ve her bir geometrik şekil için bir sınıf oluşturularak kendi alan hesaplamalarına sahip olduğundan emin olmalıyız.

[-ISP Examples](https://github.com/YagizcanSeheri/SOLIDPrinciples/tree/master/SOLIDPrinciples/Interface%20Segration%20Principle)<br/>

5.) **Dependency Inversion Principle** 

-Bir sınıfın içerisinde başka bir sınıf kullanıyorsanız somut hali ile değil soyut haliyle kullanılmalıdır, varlıklar somutlara değil soyutlamalara bağlı olmalıdır<br/>
-Bu prensip üst düzey modülün alt düzey modüllere bağlı olmaması gerektiğini savunur. Ancak soyutlamalara bağlı olması gerektiğini belirtir.<br/>

"Üst düzey modülün alt düzey modülere bağlı olmaması gerektiğini savunur." Bu cümleyi birazcık açacak olursak, üst düzey bir sınıfta bir değişiklik yaptığımızda bu değişiklikten etkilenecek sınıf sayısının optimum düzeyde olması gerekir.

[-DIP Examples](https://github.com/YagizcanSeheri/SOLIDPrinciples/tree/master/SOLIDPrinciples/Dependency%20Inversion%20Principle)


