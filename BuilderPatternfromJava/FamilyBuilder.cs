namespace C_
{
    class FamilyBuilder{

        public static void Main(string[] args)
        {

            Person vasya = new Person.FamilyBuilder("Вася", true).build();
            Person masha = new Person.FamilyBuilder("Маша", false).build();
            Person kolya = new Person.FamilyBuilder("Коля", true).setMother(masha).setFather(vasya).build();
            Person alevtina = new Person.FamilyBuilder("Алевтина", false)
                .setMother(masha).setFather(vasya).setSisterOrBrother(kolya).build();
            Person vasilisa = new Person.FamilyBuilder("Василиса Петровна", false)
                .setChild(vasya).build();
            Person nikolay = new Person.FamilyBuilder("Николай Иванович", true)
                .setChild(vasya).build();
            Person olga = new Person.FamilyBuilder("Ольга Бузова", false)
                .setChild(masha).build();
            Person timur = new Person.FamilyBuilder("Тимур Батрутдинов", true)
                .setChild(masha).build();
            Person filipp = new Person.FamilyBuilder("Филипп Киркоров", true)
                .setChild(nikolay).build();
            foreach (Person person in Person.Family)
            {
                Console.WriteLine(person);
            }
        }
    }
}