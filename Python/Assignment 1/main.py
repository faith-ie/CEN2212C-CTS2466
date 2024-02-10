import getpass
def get_name():
    print("     ---Welcome " + getpass.getuser() + "---")


def selection_menu():
    number_of_attempts = 0
    one_to_five_zephyr_sms = 1.5
    six_or_more_zephyr_sms = 1.0
    one_to_five_titan_sms = 2.5
    six_or_more_titan_sms = 2.0

    while True:
        print("Welcome to Space Voyagers Inc.! Choose your adventure:\n1 - Purchase SVI ZEPHYR SMs\n2 - Purchase SVI TITAN SMs\n3 - Exit Program")

        try:
            choice = int(input())
        except ValueError:
            print("Invalid input. Please enter a valid number.")
            number_of_attempts += 1
            if number_of_attempts == 5:
                print("You have exceeded the number of correct input attempts. We will now exit.")
                break
            continue

        if choice == 3:
            print("Thank you for visiting Space Voyagers Inc. Safe travels!")
            break

        how_much_to_buy = int(input(f"How many {'SVI ZEPHYR' if choice == 1 else 'SVI TITAN'} SMs would you like to buy?"))

        if how_much_to_buy <= 0:
            print("Invalid number, value needs to be one or more.")
            continue

        print("Calculating your total...\n\n")

        if choice == 1:
            if how_much_to_buy <= 5:
                print(f"For {how_much_to_buy} SVI ZEPHYR SMs, your total is ${one_to_five_zephyr_sms * how_much_to_buy} million.\nThank you for choosing Space Voyagers Inc. for your cosmic journey!")
            else:
                print(f"For {how_much_to_buy} SVI ZEPHYR SMs, your total is ${six_or_more_zephyr_sms * how_much_to_buy} million.\nThank you for choosing Space Voyagers Inc. for your cosmic journey!")

        elif choice == 2:
            if how_much_to_buy <= 5:
                print(f"For {how_much_to_buy} SVI TITAN SMs, your total is ${one_to_five_titan_sms * how_much_to_buy} million.\nWe appreciate your business and look forward to sending you beyond the stars!")
            else:
                print(f"For {how_much_to_buy} SVI TITAN SMs, your total is ${six_or_more_titan_sms * how_much_to_buy} million.\nWe appreciate your business and look forward to sending you beyond the stars!")

if __name__ == "__main__":
    get_name()
    selection_menu()