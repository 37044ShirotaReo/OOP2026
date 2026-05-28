namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var obj = new PasswordPolicy("aaaaa", "bbbbb");
            var data = obj.Name;


        }
    }
    class MySample {
        public List<int> MyList { get; private set; }

        public MySample() {
            MyList = new List<int>() { 1, 2, 3, 4, 5 };
        }
    }

    class PasswordPolicy {
        //プロパティの初期化
        public int MinimumLength { get; set; } = 8;

        //読み取り専用プロパティ
        public string GiveName { get; init; } = null!;
        public string FamilyName { get; init; } = null!;

        //getアクセサリーのみを定義した読み取り専用プロパティ
        //public string Name {
        //    get { return FamilyName + " " + GiveName; }
        //}

        public string Name => FamilyName + " " + GiveName;

        public PasswordPolicy(string familyName, string giveName) {
            FamilyName = familyName;
            GiveName = giveName;
        }
    }
}
