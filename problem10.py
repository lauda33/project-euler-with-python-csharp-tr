"""
Project Euler Problem 10

EN:The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.

TUR: 10'dan küçük asal sayıların toplamı 17'dir.

İki milyonun altındaki tüm asal sayıların toplamını bulunuz.
"""

import time

# Ne kadar sürdüğünü tespit etmek için kullanacağız
start = time.time()

# Asal sayılar listemize ikiyi ekleyerek başladık
primes = [2]

# 3'ten 2 milyona kadar bir for döngüsü başlattık
for i in range(3,2000000):
    # Bu check değişkeni sayının asal olup olmadığını kontrol edecek
    check = True
    # ikiden kontrol edilen sayının bir eksiğinde bir for döngüsü başlattık
    for j in range(2,i):
        
        # eğer her hangi bir j değeri kontrol edilen sayıya kalansız bölünürse
        # yani bu sayının kendisi ve 1 hariç bir böleni varsa
        if i%j == 0:
            
            check = False
            break
       
    # Eğer sayı asalsa listeye ekledik
    if check:
        primes.append(i)

end = time.time()

# Listenin toplamını bulduk
process_time = round((end-start)/60,2)

print("This process took {} minutes".format(process_time))

print(sum(primes))


"""
Bitiş notu: Google Colabrotary ortamında bu kodun çalışması 262 dakika sürmüştür.

"""


