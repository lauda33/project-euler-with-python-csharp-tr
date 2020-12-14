"""
Project Euler Problem 3

EN:The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143 ?

TUR:13195'in asal çarpanları 5,7,13 ve 29'dur.
600851475143 sayısının en büyük asal çarpanı nedir?

"""

import time

# İşlem süresini hesaplamak için
start_time = time.time()

num = 600851475143
# Bu değişkende depolayacağız
large_prime = 0 

# 2'den (en küçük asal sayı) bizim sayımız da dahil olacak şekilde bir for 
# döngüsü döndürdük
for i in range(2,num+1):
    
    # Eğer i sayımızın bir çarpanıysa
    if num%i == 0:
        
        factors_of_i = []
        # Sayının asal olup olmadığını anlamak için
        # 1 den çarpan dahil olacak şekilde bir for döngüsü döndürdük
        for j in range(1,i+1):
            
            # Eğer j i'nin çarpanıysa listeye ekledik
            if i%j == 0:
                factors_of_i.append(j)
            
            # Bir asal sayı sadece kendisine ve bire bölünür
            # Eğer sayının çarpanları toplamı 1 ve kendisinin toplamına eşitse
            if sum(factors_of_i) == 1+i:
                # Ve bir önceki asal sayıdan büyükse
                if i>large_prime:
                    large_prime = i
                    
end_time = time.time()

print("These process took {} minutes".format(round(end_time-start_time),2))
print("Largest prime factor of {} is {}".format(num,large_prime))
            