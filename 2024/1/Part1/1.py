f = open("input.txt")
list1 = []
list2 = []
for i in f:
    i = i.removesuffix("\n")
    x = i.split("   ")
    list1.append(x[0])
    list2.append(x[1])

list1.sort()
list2.sort()

somme = 0
for i in range(0, len(list1)):
    somme += abs(int(list1[i]) - int(list2[i]))
print(somme)