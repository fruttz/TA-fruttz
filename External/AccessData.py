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

def reset_data(candidate):
    for key in candidate:
        if key != "name":
            ref.child(candidate["name"]).update({
                key : 0
            })

def update_data(candidate):
    for key in candidate:
        if key != "name":
            candidate[key] += random.randint(0, 100)
            ref.child(candidate["name"]).update({
                key : candidate[key]
            })

def main():
    n = 1
    while True:
        print(f"iteration number {n}")
        update_data(candidate1)
        update_data(candidate2)
        n += 1
        time.sleep(2)

main()
