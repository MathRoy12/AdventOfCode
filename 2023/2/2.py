f = open("input.txt")
x = f.readlines()
cpt = 0
for y in x:
    cptbleu = 0
    cptrouge = 0
    cptvert = 0
    y = y.split(':')
    y[0] = y[0].removeprefix("Game ")
    y[1] = y[1].split(";")
    for z in y[1]:
        z = z.split(",")
        for s in z:
            if(s.__contains__("blue")):
                if(int(s.split(" ")[1]) > cptbleu):
                    cptbleu = int(s.split(" ")[1])
            if(s.__contains__("red")):
                if(int(s.split(" ")[1]) > cptrouge):
                    cptrouge = int(s.split(" ")[1])
            if(s.__contains__("green")):
                if(int(s.split(" ")[1]) > cptvert):
                    cptvert = int(s.split(" ")[1])
    cpt += (cptbleu * cptrouge * cptvert)

print(cpt)
f.close()