using System.Collections;

namespace C_{

    public class Person {

        public static List<Person> Family {get;} = new List<Person>();

        private string NameSurname {get; set;}
        private bool Sex {get; set;}
        private Person? _mother;
        private Person? _father;
        private Person? _child;
        private Person? _sisterOrBrother;

        private Person(FamilyBuilder familyBuilder) {

            this.NameSurname = familyBuilder.getNameSurname();
            this.Sex = familyBuilder.getSex();
            if (familyBuilder.getMother() is not null) {
                this.setMother(familyBuilder.getMother());
            }
            if(familyBuilder.getFather() is not null) {
                this.setFather(familyBuilder.getFather());
            }
            if (familyBuilder.getChild() is not null) {
                this.setChild(familyBuilder.getChild());
            }
            if (familyBuilder.getSisterOrBrother() is not null) {
                this.setSisterOrBrother(familyBuilder.getSisterOrBrother());
            }
            Family.Add(this);
        }

        public string getNameSurname() {
            return NameSurname;
        }

        public bool isSex() {
            return Sex;
        }

        public Person? getMother() {
            return _mother;
        }

        public Person? getFather() {
            return _father;
        }

        public Person? getChild() {
            return _child;
        }

        public Person? getSisterOrBrother() {
            return _sisterOrBrother;
        }

        public static List<Person> getFamily() {
            return Family;
        }

        public void setMother(Person mother) {
            this._mother = mother;
            mother._child = this;
        }

        public void setFather(Person father) {
            this._father = father;
            father._child = this;
        }

        public void setChild(Person child) {
            this._child = child;
            if (Sex) child._father = this;
            else child._mother = this;
        }

        public void setSisterOrBrother(Person sisterOrBrother) {
            this._sisterOrBrother = sisterOrBrother;
            sisterOrBrother._sisterOrBrother = this;
        }

        public override string ToString()
        {
            string outMother = (_mother is null) ? "" :
                ", маму зовут: " + _mother.getNameSurname();

            string outFather = (_father is null) ? "" :
                ", папу зовут: " + _father.getNameSurname();

            string outChild = (_child is null) ? "" :
                ", ребенка зовут: " + _child.getNameSurname();

            string outSisterOrBrother = (_sisterOrBrother is null) ? "" :
                ", сестру/брата зовут: " + _sisterOrBrother.getNameSurname();

            return "Член семьи " +
                "с именем " + NameSurname +
                outMother +
                outFather +
                outSisterOrBrother +
                outChild;;
        }


        public class FamilyBuilder {
            private string _nameSurname;
            private bool _sex;
            private Person? _mother;
            private Person? _father;
            private Person? _child;
            private Person? _sisterOrBrother;


            public FamilyBuilder(string nameSurname, bool sex) {
                this._nameSurname = nameSurname;
                this._sex = sex;
            }

            public bool getSex() {
                return _sex;
            }

            public string getNameSurname() {
                return _nameSurname;
            }

            public Person? getMother() {
                return _mother;
            }

            public Person? getFather() {
                return _father;
            }

            public Person? getChild() {
                return _child;
            }

            public Person? getSisterOrBrother() {
                return _sisterOrBrother;
            }

            public FamilyBuilder setMother(Person mother) {
                this._mother = mother;
                return this;
            }

            public FamilyBuilder setFather(Person father) {
                this._father = father;
                return this;
            }

            public FamilyBuilder setChild(Person child) {
                this._child = child;
                return this;
            }

            public FamilyBuilder setSisterOrBrother(Person sisterOrBrother) {
                this._sisterOrBrother = sisterOrBrother;
                return this;
            }

            public Person build() {
                return new Person(this);
            }
        }
    }
}