# OOP class and loop example
class Member:
    def __init__(self, firstname, middlename, lastname):
        self.firstname = firstname
        self.middlename = middlename
        self.lastname = lastname

    def get_full_name(self):
        return f"{self.firstname} {self.middlename} {self.lastname}"

    def name_with_title(self, title):
        if title == "mr.":
            greeting = "Hello Mr."
        elif title == "ms.":
            greeting = "Hello Ms."
        else:
            greeting = "Hello"
        return f"{greeting} {self.firstname} {self.middlename} {self.lastname}"

    def get_all_info(self, title):
        return f"Hello {title}, Your full name is: {self.get_full_name()}"

member1 = Member("salma", "sh.", "hassan")
member2 = Member("sedra", "adb.", "shaar")
member3 = Member("sama", "w.", "abdou")
member4 = Member("habiba", "r.", "hassan")

members = []
members.append(member1)
members.append(member2)
members.append(member3)
members.append(member4)

for member in members:
    print(member.get_full_name())
    print(member.name_with_title("ms."))
    print(member.get_all_info("ms."))
    print("-" * 50)
