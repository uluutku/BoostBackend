# Adım 1: Başla

# Adım 2
sayac = 2

# Adım 3
while sayac <= 100:
    payda = 2
    bolenSayisi = 0
    
    # Adım 3a
    while payda <= (sayac / 2):
        if sayac % payda == 0:
            bolenSayisi += 1
            break
        payda += 1
    
    # Adım 3d
    if bolenSayisi == 0:
        print(sayac, "Bir asal sayıdır.")
    
    # Adım 3e
    sayac += 1

# Adım 4: Bitir