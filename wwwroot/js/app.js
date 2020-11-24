// Your web app's Firebase configuration
const firebaseConfig = {
    apiKey: "AIzaSyCOFZb-hJHhcoUOl_1tqj8qqhxXLlx75xM",
    authDomain: "planetagundam.firebaseapp.com",
    databaseURL: "https://planetagundam.firebaseio.com",
    projectId: "planetagundam",
    storageBucket: "planetagundam.appspot.com",
    messagingSenderId: "851351999948",
    appId: "1:851351999948:web:f7efc113d8c36b74933969"
};

// Initialize Firebase
firebase.initializeApp(firebaseConfig);

var db = firebase.firestore();

window.fetchCrests = async () => {
    let crests = []
    const querySnapshot = await db.collection("crests").get()
    querySnapshot.forEach(doc => crests.push({ ...doc.data(), id: doc.id }))
    return crests
}

window.fetchMembers = async () => {
    let members = []
    const querySnapshot = await db.collection("members").get()
    querySnapshot.forEach(doc => members.push({ ...doc.data(), id: doc.id }))
    return members
}

window.setLocalStorageItem = (key, value) => {
    if (localStorage.getItem(key))
        localStorage.removeItem(key)
    
    localStorage.setItem(key, value)
}

window.getLocalStorageItem = key => {
    if (localStorage.getItem(key))
        return localStorage.getItem(key)
    else
        return ""
}

window.registerVote = async (member, crest_id) => {
    let members = []
    const querySnapshot = await db.collection("members").get()
    querySnapshot.forEach(doc => members.push({ ...doc.data(), id: doc.id }))
    console.log(members)
    member = members.find(m => m.name == member)
    console.log(crest_id)

    if (member.hasVoted) {
        alert("You have already voted!")
    } else {
        let crestRef = await db.collection("crests").doc(crest_id)
        crestRef.update({ voters: firebase.firestore.FieldValue.arrayUnion(member.name)})
        
        // Find Member ID
        const memberRef = await db.collection("members").doc(member.id)
        memberRef.update({
            hasVoted: true
        })
        alert("Voted registered successfully!")
    }

}