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

TOTAL_VOTER_OVERALL = 150000000

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
            candidate[key] += random.randint(100, 100000)
            ref.child(candidate["name"]).update({
                key : candidate[key]
            })

def random_update(value):
    print("random value: ", value)
    if value == 1:
        update_data(candidate1)
    elif value == 2:
        update_data(candidate2)

def main():
    n = 1
    while (calculate_total(candidate1) + calculate_total(candidate2) <= TOTAL_VOTER_OVERALL):
        print(f"iteration number {n}")
        random_update(random.randint(1,2))
        n += 1
        time.sleep(2)
    if calculate_total(candidate1) + calculate_total(candidate2) >= TOTAL_VOTER_OVERALL:
        print("Total voter reached, data stopped")

main()