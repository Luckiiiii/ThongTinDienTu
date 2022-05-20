function checkdangky() {
    email = document.getElementById("email").value;
    hoten = document.getElementById("hoten").value;
    pass = document.getElementById("pass").value;
    repass = document.getElementById("repass").value;
    loi_email = document.getElementById("loi_email");
    loi_ht = document.getElementById("loi_ht");
    loi_pass = document.getElementById("loi_pass");
    loi_repass = document.getElementById("loi_repass");
    checkloi = true;
    //email
    if (email == "") {
        loi_email.style.display = "block";
        loi_email.innerHTML = "Chưa nhập";
        checkloi = false;
    }
    else {
        loi_email.innerHTML = "";
        loi_email.style.display = "none";
    }

    return checkloi;


}