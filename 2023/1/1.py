f = open("word.txt")

x = f.readlines()

list2 = []
for y in x:
    #print(y)
    y = y.replace("nine","nine9nine")
    y = y.replace("eight","eight8eight")
    y = y.replace("seven","seven7seven")
    y = y.replace("six","six6six")
    y = y.replace("five","five5five")
    y = y.replace("four","four4four")
    y = y.replace("three","three3three")
    y = y.replace("two","two2two")
    y = y.replace("one","one1one")

    list = []
    for z in y:
        if(z.isnumeric()):
            list.append(z)

    p = list[0]
    q = list[-1]
    list2.append(p + q)
    #print(list)
    #print(p+q)

cpt = 0
for y in list2:
    cpt += int(y)
print(cpt)

f.close()