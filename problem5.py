"""
Project Euler Problem 5

EN:2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

TUR: 2520 1 den 10 a kadar tüm sayıların kalansız bölündüğü en küçük sayıdır

1'den 20'ye kadar tüm sayıların kalansız böldüğü en küçük sayı nedir?

"""

# Problemi anlamak: Problem bizden 1 den 20'ye kadarki tüm sayıların ekokunu istiyor
# Defterimizde tablo oluştururcasına çözeceğiz bu soruyu
    
# 1 den 20'ye tüm asal sayılar
# Bu asal sayıları EKOK hesaplarken kullanacağız
all_prime_factors = [2,3,5,7,11,13,17,19]
    
numbers = list(range(1,21))

# Kullandığımız çarpanları bu listeye ekleyeceğiz
used_factors = []

"""
Hatırlıyorsanız EKOK hesaplarken tüm sayıları 1 yapana dek asal bölüyorduk
yine öyle yapacağız bu yüzden tüm sayılar bir olana dek çalışacak bir döngü başlattık.
"""
while sum(numbers) != 20:
    
    # Asal çarpanlarımızı tek tek döndürüyoruz
    for factor in all_prime_factors:
        check = False
        # 1 den 20 ye sayılarımızı tek tek döndürüyoruz
        for number in numbers:
            # Eğer sayı asal sayımıza bölünüyorsa bölüyoruz ve bu asal sayıyı
            # kullandığımızı tespit etmek için False'u True'ya dönüştürüyoruz
            if number%factor == 0:
                check = True
                numbers[numbers.index(number)] = number//factor
        # Eğer sayıyı kullandıysak 
        # kullanılan çarpanlar listesine ekliyoruz
        if check:
            used_factors.append(factor)
                
        

    
result = 1
for i in used_factors:
    result = result*i
    
print(result)
            
