from os import remove

with open('links_list.txt', encoding='utf8') as file:
    for line in file:
        try:
            remove(line.strip())
        except FileNotFoundError:
            print('Ярлык уже удален')
