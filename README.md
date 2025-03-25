This is a small program that gets updates to flight prices and sends notifications to user by thier constraints.
I used an event to distribute the notification, I guess in the real world I will write the update to some kind of broker an let the clients to subscribe to his wanted topics.
Data structers :
I'm using a dictionary to keep the usersData.
Design Pattern:
Every User data observes the flights updater (which should be a singleton) and send notification to user's client if needed.
I'm using also DI and solid principle as much as relevant.    

