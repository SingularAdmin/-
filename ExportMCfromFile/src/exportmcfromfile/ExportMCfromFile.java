
package exportmcfromfile;

import jxl.Cell;
import jxl.Sheet;
import jxl.Workbook;
import jxl.read.biff.BiffException;

import java.io.File;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class ExportMCfromFile {

    public static void main(String[] args) throws ClassNotFoundException, SQLException {
    Workbook workbook = null;
        try {

            workbook = Workbook.getWorkbook(new File("Book1.xls"));      // use Book1.xls for all the data, and test.xls for a small sample

            Sheet sheet = workbook.getSheet(0);
            final int ROWS = sheet.getRows();
            String[][] excel = new String[ROWS][8];
            int countMultipleChoice = 0;

            for (int i = 0; i<ROWS; i++){
                if ( sheet.getCell(1,i).getContents().equals("multiple")){
                    countMultipleChoice++;
                }
                for (int k = 0; k<8; k++){
                    excel[i][k] = sheet.getCell(k,i).getContents();
                }
            }
            
            //System.out.println(countMultipleChoice);        //prints the number of the multiple choices
            String[][] mc = new String[countMultipleChoice][8]; // contains all the excel lines that are about MC, not true false questions.
            int count = 0;
            for (int i=0; i<ROWS; i++){
                if ( excel[i][1].equals("multiple")){
                    for ( int k = 0; k <8; k++)
                        mc[count][k] = excel[i][k];
                    count++;
                }
            }

            //findAllCategories(ROWS, mc);
            System.out.println("All is good.");
            System.out.println(mc[1][1]);
            
//            Class.forName("com.mysql.cj.jdbc.Driver");
//            Connection con=DriverManager.getConnection(
//            "jdbc:mysql://83.212.96.191:3306/MC","root","mplemilo");
//            Statement stmt=con.createStatement();
//            PreparedStatement preparedquery = null;
//            String sqlquery;
//            String dif="patata";
//            boolean flagA=false;
//            int countAnswerID=0;
//            int correct=0;
//            int categoryID = 1;
//            for (int i = 0; i<countMultipleChoice; i++){
//                System.out.println(i);
//                if ( mc[i][2].equals("easy")){
//                    dif = "E";
//                }
//                else if (mc[i][2].equals("medium")){
//                    dif = "M";
//                }
//                else if (mc[i][2].equals("hard")){
//                    dif = "H";
//                }
//                
//                sqlquery = "insert into Media(mediaID,type,link) values ("+ (i+1)+",'T',?)";
//                preparedquery = con.prepareStatement(sqlquery);
//                preparedquery.setString(1,  mc[i][3]);
//                preparedquery.executeUpdate();
//                
//                sqlquery = "insert into Question(questionID,difficulty,mediaID) values ("+ (i+1)+",'"+ dif +"'," + (i+1) + ")";
//                stmt.executeUpdate(sqlquery);
//
//                categoryID = assosiateCategoryWithQuestion(mc,i);
//                sqlquery = "insert into hasCategory(questionID,categoryID) values (" + (i+1) + "," + categoryID+ ") ";
//                stmt.executeUpdate(sqlquery);
//                
//                
//
//                correct = (int)(Math.random()*4);
//                if ( correct < 1){
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 1)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][4]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID + 1 +",1,"+(countMultipleChoice  + countAnswerID + 1)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 1 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                    
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 2)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][5]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID + 2 +",0,"+(countMultipleChoice  + countAnswerID + 2)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 2 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                    
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 3)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][6]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID + 3 +",0,"+(countMultipleChoice  + countAnswerID + 3)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 3 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                    
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 4)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][7]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID + 4 +",0,"+(countMultipleChoice  + countAnswerID + 4)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 4 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                    
//                    countAnswerID +=4;
//                    }
//                else if ( correct < 2){
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 2)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][5]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID + 2 +",1,"+(countMultipleChoice  + countAnswerID + 2)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 2 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                    
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 1)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][4]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID + 1 +",0,"+(countMultipleChoice  + countAnswerID + 1)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 1 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                    
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 3)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][6]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID + 3+",0,"+(countMultipleChoice  + countAnswerID + 3)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 3 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                    
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 4)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][7]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID + 4 +",0,"+(countMultipleChoice  + countAnswerID + 4)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 4 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                    
//                    countAnswerID += 4;
//                }
//                else if ( correct < 3){
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 3)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][6]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID + 3 +",1,"+(countMultipleChoice  + countAnswerID + 3)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 3 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                   
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 2)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][5]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID + 2+ ",0,"+(countMultipleChoice  + countAnswerID + 2)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 2 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                    
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 1)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][4]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID + 1 +",0,"+(countMultipleChoice  + countAnswerID + 1)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 1 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                    
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 4)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][7]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID + 4 +",0,"+(countMultipleChoice  + countAnswerID + 4)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 4 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                    
//                    countAnswerID += 4;
//                }
//                else if ( correct < 4){
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 4)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][7]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID +4+",1,"+(countMultipleChoice  + countAnswerID + 4)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 4 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                    
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 3)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][6]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID +3+",0,"+(countMultipleChoice  + countAnswerID + 3)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 3 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                    
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 2)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][5]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID +2+",0,"+(countMultipleChoice  + countAnswerID + 2)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 2 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                    
//                    sqlquery = "insert into Media(mediaID,type,link) values ("+ (countMultipleChoice  + countAnswerID + 1)+",'T',?)";
//                    preparedquery = con.prepareStatement(sqlquery);
//                    preparedquery.setString(1,  mc[i][4]);
//                    preparedquery.executeUpdate();
//                    sqlquery = "insert into Answer(answerID,isCorrect,mediaID) values ("+ countAnswerID +1+",0,"+(countMultipleChoice  + countAnswerID + 1)+")";
//                    stmt.executeUpdate(sqlquery);
//                    sqlquery = "insert into hasAnswers(questionID,answerID) values (" +(i+1)+ "," + countAnswerID + 1 + ")";
//                    stmt.executeUpdate(sqlquery);
//                    
//                    
//                    countAnswerID += 4;
//                }
//                
//                
//            }
//            con.close(); 

        } catch (IOException e) {
            e.printStackTrace();
        } catch (BiffException e) {
            e.printStackTrace();
        } finally {
            if (workbook != null) {
                workbook.close();
            }
        } 
    }    

    private static void findAllCategories(final int ROWS, String[][] mc) {
        String[] category = new String[50];
        String currentCategory;
        boolean flag;
        int count = -1;
        for (int i = 0; i<mc.length; i++){
            flag = true;
            currentCategory = mc[i][0];
            for (int k = 0; k<count; k++){
                if ( currentCategory == category[k]){
                    flag = false;
                }
            }
            if ( flag ){
                count++;
                category[count] =currentCategory;
                System.out.println(currentCategory);
            }
        }
    }

    private static int assosiateCategoryWithQuestion(String[][] mc, int i) {
        String categoryName = mc[i][0];
        
        if ( categoryName.equals("Entertainment: Video Games"))
            return 12;
        else if ( categoryName.equals("Entertainment: Television"))
            return 13;
        else if ( categoryName.equals("Science & Nature"))
            return 3;
        else if ( categoryName.equals("Entertainment: Japanese Anime & Manga"))
            return 14;
        else if ( categoryName.equals("History"))
            return 25;
        else if ( categoryName.equals("Politics"))
            return 4;
        else if ( categoryName.equals("Geography"))
            return 5;
        else if ( categoryName.equals("Entertainment: Music"))
            return 15;
        else if ( categoryName.equals("Vehicles"))
            return 6;
        else if ( categoryName.equals("Science: Gadgets"))
            return 22;
        else if ( categoryName.equals("Science: Computers"))
            return 23;
        else if ( categoryName.equals("Entertainment: Cartoon & Animations"))
            return 16;
        else if ( categoryName.equals("Entertainment: Comics"))
            return 17;
        else if ( categoryName.equals("Entertainment: Film"))
            return 18;
        else if ( categoryName.equals("General Knowledge"))
            return 26;
        else if ( categoryName.equals("Sports"))
            return 7;
        else if ( categoryName.equals("Celebrities"))
            return 8;
        else if ( categoryName.equals("Entertainment: Board Games"))
            return 21;
        else if ( categoryName.equals("Science: Mathematics"))
            return 24;
        else if ( categoryName.equals("Animals"))
            return 9;
        else if ( categoryName.equals("Entertainment: Books"))
            return 19;
        else if ( categoryName.equals("Entertainment: Musicals & Theatres"))
            return 20;
        else if ( categoryName.equals("Mythology"))
            return 11;
        else if ( categoryName.equals("Art"))
            return 10;
        
        return 0;
        
    }
}
