"""
Project Euler Problem 7

EN:By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?

TUR:İlk altı asal sayı:2,3,57,11 ve 13'dır. Görebiliriz ki altıncı asal sayı 13'dür.

10 001'inci asal sayı nedir?
"""

import time

# asal sayıları bu listeye kaydedeceğiz
prime_numbers = [2]

# son kontrol ettiğimiz sayıyı bu değişkende tutacağız, bu değişkeni bir bir arttıracağız
last_checked = 2

# toplam işlem süresini hesaplamak için 
start = time.time()

# listedeki asal sayı sayısı 10 001 den azken
while len(prime_numbers) < 10001:
    
    # son kontrol ettiğimiz sayıyı bir arttırdık
    last_checked = last_checked + 1
    
    # bu sayının çarpanlarını bu listede tutacağız
    # her sayı kendisine ve 1'e bölünür, bu yüzden onları en başta ekledik
    factors_of_last_checked = [1,last_checked]
    
    # bu değişkeni asal olup olmadığını tespit ederken kullanacağız
    check = True
    
    # 2'den (çünkü 1'i zaten ekledik) sayının 1 eksiğine kadar bir 
    # for döngüsü başlattık
    for i in range(2,last_checked):
        
        # Eğer i sayıyı kalansız bölüyorsa yani çarpanıysa
        if last_checked%i == 0:
            # çarpanlar listesine ekledik
            factors_of_last_checked.append(i)
            
        # eğer çarpanlar listesinde bir ve sayının kendisi hariç bir şey varsa
        if sum(factors_of_last_checked) != last_checked+1:
            # sayı asal değildir
            check = False
            # döngüyü bitir
            break
        
    # eğer sayı asalsa listeye ekle
    if check:
        prime_numbers.append(last_checked)
    
end = time.time()

print("10001th prime number is {}".format(prime_numbers[-1]))
print("This process took {} minutes".format(round((end-start)/60,2)))

