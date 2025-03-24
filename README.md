This is a small program that getsupdates to flight prices and sends notifications to user by thier constraints.
Data structers :
I'm using a dictionary to keep the usersData.
Design Pattern:
Every User data observes the flights updater (which should be a singleton) and send notification to user's client if needed.
I'm using also DI and solid principle as much as relevant.   