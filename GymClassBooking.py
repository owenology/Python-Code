

# CONSOLE BASED APP

# Class Booking:



classes = [[1, "Spin", "Monday", "18:00"], [2, "Running", "Tuesday", "17:30"], [3, "Body Blast", "Thursday", "18:30"], [4, "Weight Lifters", "Friday", "17:45"], [5, "CrossFit", "Saturday", "10:30"], [6, "Abdominal Training", "Sunday", "10:30"]]
# classID, className, weekday, time


users = [[1, "Owen", "O'Brien", "owenPass"], [2, "Will", "King", "wkForever"], [3, "Josh", "Powell", "bmw123"], [4, "Ant", "Tobin", "gym18"]]
# userID, firstName, lastName, password

userBookings = [[1], [2], [3], [4]]
# userID, space to add classes

usersPastAttended = [[1, "Body Blast", "Thursday", "18:30"], [2, "Weight Lifters", "Friday", "17:45"], [3, "Spin", "Monday", "18:00"], [4, "Running", "Tuesday", "17:30"]]
# userID, className, day, time ------- put in place to display past attended classes.

userIndex = "" # Used to keep hold of the user's ID once Logged In.

def classFunc():
    global userIndex
    print("\n------------ CLASSES: ------------")
    
    for i in range(len(classes)):
        print(f"\nClass: {classes[i][1]} \n Day: {classes[i][2]} \n Time: {classes[i][3]}") # Prints all the available classes.
    print("\n------------------------")



    userCorrectChoice = False

    while userCorrectChoice == False:
        print("\nIf you don't want to book any type: 'Cancel'.")
        print("If you want to see your current classes, type: 'Classes'")
        print("If you want to see the options, type 'Show again'.")
        userClassChoice = input("What class would you like to go to? : ")  # Basic Screen to select different Classes, to look at current classes or to Cancel.
        classFound = False
        confirmScreen = False
        
        if userClassChoice.lower() == "cancel": # Cancellation code
            print("\nCancelled the booking screen.")
            accountMenu()
            userCorrectChoice = True
        elif userClassChoice.lower() == "classes": # Look at current classes code
            print("\n------------------------")
            print(f"\nCurrent Classes: {userBookings[userIndex - 1][1:]}.")
            leaveClassSelect = input("Would you like to go back and book more classes? (Y/N): ") 
            if leaveClassSelect.lower() in ["yes", "y"]:
                print("\n------------------------")
                print("Going Back...")
                print("\n------------------------")
            else:
                print("\n------------------------")
                print("Because your answer wasnt 'Yes' / 'Y', we aren't sending you back.")
                print("\n------------------------")
                userCorrectChoice = True
                accountMenu()
        elif userClassChoice.lower() in ['show', 'show again', 's', 'again']:
            for i in range(len(classes)):
                print(f"\nClass: {classes[i][1]} \n Day: {classes[i][2]} \n Time: {classes[i][3]}") # Prints all the available classes.
                print("\n------------------------")
        else:
            for i in range(len(classes)): # Screen after picking the class you want to go to.
                if userClassChoice.lower() == classes[i][1].lower() and userClassChoice not in userBookings[userIndex - 1] or userClassChoice.lower() == classes [i][2].lower() and userClassChoice not in userBookings[userIndex - 1] or userClassChoice.lower() == classes[i][3].lower() and userClassChoice not in userBookings[userIndex - 1]: # Makes sure class is real and not already in user's Bookings.
                    classFound = True
                    print("\n------------------------")
                    print(f"\nDay: {classes[i][2]}, Time: {classes[i][3]}.")
                    print(f"Class Selected: {classes[i][1]}.")
                    confirmClass = input("\nWas this class the correct choice? Y/N: ")
                    if confirmClass.lower() in ["yes", "y"]: # Confirmed your choice.
                        print(f"\n{classes[i][1]} class selected.")
                        userBookings[userIndex - 1].append(classes[i][1])
                        userBookings[userIndex - 1].append(classes[i][2])
                        userBookings[userIndex - 1].append(classes[i][3])
                        print(f"Current Classes: {userBookings[userIndex - 1][1:]}")
                        userCorrectChoice = True
                        userMore = False
                        print("\n------------------------")
                        while userMore == False: # Decide if you want to book more classes
                            userChooseMore = input("\nWould you like to pick more classes to go to? (Y/N): ")
                            if userChooseMore.lower() in ["yes", "y"]:
                                userMore = True
                                classFunc()
                            else:
                                print("\nWe're assuming you don't want to do more based on answer not being 'Yes' / 'Y'.")
                                userMore = True
                                accountMenu()
                    else:
                        print(f"\n{classes[i][1]} class was not selected.") # Unconfirm the class you selected.
                        print("\n------------------------")
            if not classFound:
                print("\nClass Doesn't Exist, or was Booked Already.\n") # Screen if you type in the wrong class, or already booked that class.
                print(f"\nCurrent Classes: {userBookings[userIndex - 1][1:]}.")

        

def pastAttendedClasses():
    global userIndex
    
    usersPastAttendedConfirm = False

    print("\n------------ PAST ATTENDED: ------------")

    found = False

    for record in usersPastAttended:
        if record[0] == userIndex:
            print("\n",record[1:])      # Shows Past Attended Classes
            found = True
            break
    if not found:
        print("No past attended found")

    while usersPastAttendedConfirm == False:
        userPastAttendedChoice = input("\nWould you like to go back to the account menu screen? (Y/N): ") # gives option to go back to menu
        if userPastAttendedChoice.lower() in ['yes', 'y', 'ye']:
            usersPastAttendedConfirm = True
            accountMenu()
        elif userPastAttendedChoice.lower() in ['no', 'n']:
            print("\n------------------------")
            print("\n Exiting...")
            print("\n------------------------")
            usersPastAttendedConfirm = True
        else:
            print("Invalid input, try again.")

def nameValidation(name): # Function For validating names in the Create account feature

    name = name.strip()

    if len(name) < 2:
        return False

    for char in name:
        if not (char.isalpha() or char in ["-", "'"]):
            return False
    
    return True


def accountCreation():
    global userIndex

    accountNamesSuccessful = False
    accountCreationSuccesful = False

    print("\n------------ CREATE ACCOUNT: ------------")

    while accountNamesSuccessful == False:
        accountExists = False

        
        while True: # Enter first name
            firstName = input("\nPlease enter your first name: ") 
            if nameValidation(firstName): # Links back to name Validation Function
                break
            else:
                print("Invalid first name. Use only letters, hyphens or apostrophes.")

        while True: # Enter last Name
            lastName = input("Please enter your last name: ") 
            if nameValidation(lastName): # Links back to name Validation Function
                break
            else:
                print("Invalid last name. Use only letters, hyphens or apostrophes.")

        for i in range(len(users)):
            if firstName.lower() in users[i][1].lower() and lastName.lower() in users[i][2].lower(): # checks first name and last name arent already in use
                print("\nWe believe you already have an account, try again.")
                accountExists = True
        if not accountExists:
            accountNamesSuccessful = True

    if accountNamesSuccessful == True:  # if the names aren't pre-existing, then create a password
        while accountCreationSuccesful == False:
            print("\nYour password has to be at least 8 characters long.")
            userPasswordCreate = input("Please create a password for your account: ") # Create a password
            if len(userPasswordCreate) < 8 or userPasswordCreate.lower() == "password" or userPasswordCreate.lower() == "password123" or userPasswordCreate.lower() == "123password":
                print("\n Your password did not meet our criteria:")
                print("\n• Cannot be less than 8 characters. \n• Cannot be 'password'. \n• Cannot be 'password123'. \n• Cannot be '123password'. \n• Cannot insult Owen.")
            elif len(userPasswordCreate) >= 8: # if password isnt 8 chars or more, it rejects it.
                newID = users[-1][0] + 1
                users.append([newID, firstName, lastName, userPasswordCreate])
                userBookings.append([newID])
                usersPastAttended.append([newID, "None", "None", "None"]) 
                userIndex = newID
                accountCreationSuccesful = True
                print(f"\n{firstName}, your account creation was succesful!")
                accountMenu()
            else:
                print("\nSomething was invalid or something idek you shouldn't see this message ever")
        

def userLogScreen(): # User Log In Screen
    global userIndex
    userLoginConfirm = False
    passwordCorrect = False
    
    print("\n------------ LOG IN: ------------")


    while userLoginConfirm == False:
        userLoginOption = input("\nWould you like to Create an Account or Log In?: ")
        if userLoginOption.lower() in ['create', 'c', 'create account', 'create an account']:
            userLoginConfirm = True
            accountCreation()  # Sends the user to create an account
        elif userLoginOption.lower() in ['log in', 'log', 'l']:
            userLoginFName = input("\nWhat is your first name?: ")
            userLoginLName = input("What's your last name?: ")
            for x in range(len(users)):
                userCorrect = False
                if userLoginFName.lower() == users[x][1].lower() and userLoginLName.lower() == users[x][2].lower(): # Compares the entered details to pre-existing user's names
                    userCorrect = True
                    passwordAttempts = 3
                    while passwordCorrect == False and passwordAttempts > 0: # if you havent got the passwords and still have attempts left, allows you to re-enter a password.
                        userPassword = input("\nEnter your password?: ")
                        if userPassword == users[x][3]: # Checks if the entered password is correct.
                            userLoginConfirm = True
                            passwordCorrect = True
                            userIndex = users[x][0]
                            accountMenu()
                        else:
                            passwordAttempts -= 1 # If the entered password isn't correct, -1 attempts.
                            print(f"Incorrect Password, {passwordAttempts} left.")
                        if passwordAttempts == 0:
                            print("Locked out of account.") # Locked out of account if attempts == 0.
                            userLoginConfirm = True
        else:
            print("\nInput not recognised, try again.")


def accountMenu():

    successfulSelected = False

    while successfulSelected == False:
        print("\n------------ ACCOUNT MENU: ------------") # Gives the user option to what they want to view once logged in.
        print("\nOPTIONS:")
        print("------------\n• Book or View Booked Classes \n• View Past Attended Classes \n------------\n• Log Out\n• EXIT\n------------")
        accountMenuChoice = input("Enter what you'd like to do: ")

        if accountMenuChoice.lower() in ["book classes", "book a class", "book", "booking", "booked", "view booked", "booked classes", "book or view booked classes"]:
            successfulSelected = True
            classFunc()
        elif accountMenuChoice.lower() in ["view attended", "view", "attended classes", "view past attended classes", "view past attended class", "view past", "past", "view past class"]:
            successfulSelected = True
            pastAttendedClasses()
        elif accountMenuChoice.lower() == "exit":
            print("Exiting application...")
            successfulSelected = True
        elif accountMenuChoice.lower() in ["log out", "log"]:
            successfulSelected = True
            userLogScreen()
        else:
            print("Input not recognised.")

userLogScreen()

