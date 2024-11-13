#TODO: need to create a few test cases
from tkinter import *
from math import floor
import tkinter.messagebox as box

ticket_price = [10.50, 7.30, 8.40]


def price_calc(adult, child, concession, mail):
    child_tier = floor(child / 10)
    price = (adult * ticket_price[0]) + (child_tier * ticket_price[1]) + (concession * ticket_price[2])
    if mail == 1:
        price += 2.34
    else:
        pass
    if price >= 100:
        return price - (price * 0.1) 
    else:
        return price

def submit():
    if adult.get() == "" or children.get() == "" or elderly.get() == "":
        box.showerror("Error", "Please enter a valid value")
    elif int(adult.get()) == 0 and int(children.get()) == 0 and int(elderly.get()) == 0:
        box.showerror("Error", "Please enter a valid value")
    else:
        price = price_calc(int(adult.get()), int(children.get()), int(elderly.get()), int(mail.get()))
        box.showinfo("Price", "The price is £" + str(price))

if __name__ == "__main__":
    root = Tk()
    root.title("Theatre")
    root.geometry("500x500")
    heading = Label(root, text="Theatre Booking", font=("Bold", 20))
    adult_form = Label(root, text="Adults: ", font=("Bold", 10))
    children_form = Label(root, text="Children: ", font=("Bold", 10))
    elderly_form = Label(root, text="Elderly: ", font=("Bold", 10))
    heading.grid(row=0, column=1)
    adult_form.grid(row=1, column=0)
    children_form.grid(row=2, column=0)
    elderly_form.grid(row=3, column=0)
    adult = Spinbox(root, from_=0, to=100, validate="key")
    children = Spinbox(root, from_=0, to=100, validate="key")
    elderly = Spinbox(root, from_=0, to=100, validate="key")
    adult.grid(row=1, column=1)
    children.grid(row=2, column=1)
    elderly.grid(row=3, column=1)
    mail = IntVar()
    mail_form = Checkbutton(root, text="Mail tickets", variable=mail)
    mail_form.grid(row=4, column=0)
    submit = Button(root, text="Submit", command=submit)
    submit.grid(row=4, column=1)
    root.mainloop()


