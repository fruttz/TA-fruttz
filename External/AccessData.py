import firebase_admin
from firebase_admin import credentials
from firebase_admin import db
import random
import time

cred = credentials.Certificate("immersive-visualization-pemilu-firebase-adminsdk-ca3kt-ae4089d345.json")
firebase_admin.initialize_app(cred, {
    'databaseURL': 'https://immersive-visualization-pemilu-default-rtdb.asia-southeast1.firebasedatabase.app'
})

ref = db.reference("/")
data = ref.get()

candidate1 = data["candidate1"]
candidate2 = data["candidate2"]
voter = data["voter"]


def calculate_total(candidate):
    total = 0
    for key in candidate:
        if key != "name":
            total += candidate[key]
    return total

def reset_data(candidate):
    for key in candidate:
        if key != "name":
            ref.child(candidate["name"]).update({
                key : 0
            })
    print("reset")

def update_data(candidate):
    for key in candidate:
        if key != "name":
            candidate[key] += random.randint(1000, 100000)
            ref.child(candidate["name"]).update({
                key : candidate[key]
            })

def set_voter_count(value):
    for key in voter:
        voter[key] = value
        ref.child("voter").update({
            key : voter[key]
        })

def random_update(value):
    print("random value: ", value)
    if value == 1:
        update_data(candidate1)
    elif value == 2:
        update_data(candidate2)

def reset():
    reset_data(candidate1)
    reset_data(candidate2)
    set_voter_count(0)
        
def main():
    n = 1
    if (voter["voter_count_total"] == 0):
        voter_count = random.randint(150000000, 160000000)
        set_voter_count(voter_count)
    while (calculate_total(candidate1) + calculate_total(candidate2) <= voter_count):
        print(f"iteration number {n}")
        random_update(random.randint(1,2))
        n += 1
        time.sleep(10)
    if calculate_total(candidate1) + calculate_total(candidate2) >= voter_count:
        print("Total voter reached, data stopped")

main()