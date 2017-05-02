var Person = function (firstName, middleName, lastName) {
    this.FirstName = firstName;
    this.MiddleName = middleName;
    this.LastName = lastName;

    this.GetFullName = function () {
        return this.FirstName + "" + this.MiddleName + "" + this.LastName;
    }


}