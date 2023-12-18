namespace ViewerDiscrationIsAdvised{
    public class _5Task {
        public string DeleteDoubleSlash(string code){
            if (!code.Contains("//")) return "Текст не содержит '//'";
            for (int i = 0; i < code.Length; i++){
                if (code.ToCharArray()[i] == '/' && code.ToCharArray()[i+1] == '/'){
                    while (code.ToCharArray()[i] != '\0'){
                        code.ToCharArray()[i] = ' ';
                    }
                }
            }
            return code;
        }
        
        //fsdfsdfdfsdfds
        // getProps();

        public string CodeExample(){
            return null;
        }
    }
}