using System;
using System.Collections.Generic;
using System.Text;

namespace MomQuiz
{
    public class Questions
    {
        public int Q1()
        {
            
            //A
            Console.WriteLine("Which of the following types of data/ information is primarily subjective?\n\n");
            Console.WriteLine("A. Relevant\n" +
                "B. Timely\n" +
                "C. Flexible\n" +
                "D. Verifiable");
            string q1 = Console.ReadLine();
            if (q1.ToLower() == "a") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was A. Please refer to Question ## on practice test 2.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q2()
        {
            //C
            Console.WriteLine("The purpose of a modem is to allow connection to\n\n");
            Console.WriteLine("A. Input Devices\n" +
                "B. A Printer\n" +
                "C. The Internet\n" +
                "D. Plug-In Devices");
            string q2 = Console.ReadLine();
            if (q2.ToLower() == "c") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was C. Please refer to Question ## on practice test 2.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q3()
        {
            //A
            Console.WriteLine("Cognitive informatics focuses on\n\n");
            Console.WriteLine("A. Understanding how the brain functrions in order to develop computer processes\n" +
                "B. utilizating intellectual reasoning to determine the best sources of information\n" +
                "C. acknowledging the functions of the human brain in information seeking\n" +
                "D. understanding how the computer can mimic intellectual reasoning");
            string q3 = Console.ReadLine();
            if (q3.ToLower() == "a") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was A. Please refer to Question # on practice test 2.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q4()
        {  //D
            Console.WriteLine("According to Norman's principals of design for human-technology interfaces (HITs), exploiting the power of constraints means to \n\n");
            Console.WriteLine("A. obey the rules and regulations (constraints) that affest design\n" +
                "B. rank order the constraints affecting design\n" +
                "C. determine the limits of technology in the process of design\n" +
                "D. consider how the constraints affect design");
            string q4 = Console.ReadLine();
            if (q4.ToLower() == "d") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was D. Please refer to Question ## on practice test 2.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q5()
        { //B
            Console.WriteLine("According to HIPAA privacy rules, protected health information (PHI) may be legally disclosed to law enforcement\n" +
                "officials under which of the following circumstances?\n\n");
            Console.WriteLine("A. An officer provides first aid to a person injured in a fall\n" +
                "B. A patient who came to the emergency department with a gunshot wound dies\n" +
                "C. A police officer observes a patient who reminds the officer of a fugitive\n" +
                "D. A police officer requests information about her friend who had a heart attack");
            string q5 = Console.ReadLine();
            if (q5.ToLower() == "b") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was B. Please refer to Question 66 on practice test 2.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q6()
        { //C Q66
            Console.WriteLine("The primary purpose of performance appraisal should be to\n\n");
            Console.WriteLine("A. determine compensation\n" +
                "B. identify areas of weakness\n" +
                "C. promote staff development\n" +
                "D. establish a basis for promotion/demotion");
            string q6 = Console.ReadLine();
            if (q6.ToLower() == "c") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was C. Please refer to Question 66 on practice test 2.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q7()
        {
            //A Q73
            Console.WriteLine("When utilizing outcomes data for process improvement, the primary problem is that outcomes data\n\n");
            Console.WriteLine("A. show results but not reasons\n" +
                "B. may be misrepresented\n" +
                "C. are difficult to obtain\n" +
                "D. are costly");
            string q7 = Console.ReadLine();
            if (q7.ToLower() == "a") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was A. Please refer to Question 73 on practice test 2.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q8()
        {
            //C Q77
            Console.WriteLine("When utilizing FMEA (Failure Modes and Effect Analysis) to determine how a CPOE may fail, the interdisciplinary\n" +
                "team should include at least personnel from\n\n");
            Console.WriteLine("A. informatics IT, and a nursing staff from each unit\n" +
                "B. IT and informatics\n" +
                "C. IT, informatics, nursing,pharmacy, administration, and medical staff\n" +
                "D. IT, informatics, nursing, administration, and experts in the field of computer information systems");
            string q8 = Console.ReadLine();
            if (q8.ToLower() == "c") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was C. Please refer to Question 77 on practice test 2.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q9()
        {
            //D Q63
            Console.WriteLine("In most organizations, the primary ethical dilemma is balancing\n\n");
            Console.WriteLine("A. treatment with right to death with dignity\n" +
                "B. nurse compentency with patient need\n" +
                "C. confidentiality with the need to know\n" +
                "D. provision of care with cost-effectiveness");
            string q9 = Console.ReadLine();
            if (q9.ToLower() == "d") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was D. Please refer to Question 63 on practice test 2.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q10()
        {
            //C Q57
            Console.WriteLine("According to the ANA, the steps to the nursing process include\n\n");
            Console.WriteLine("A. assessment, planning, implementation, evaluation\n" +
                "B. assessment, planning, acting, evaluating, modifying plan, reevaluating\n" +
                "C. assessment, diagnosis, outcomes/planning, implementation,and evaluation\n" +
                "D. assessment, diagnosis, planning, acting, and evaluation");
            string q10 = Console.ReadLine();
            if (q10.ToLower() == "c") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was C. Please refer to Question 57 on practice test 2.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q11()
        {
            //B Q81 PT1
            Console.WriteLine("In Which area of the hospital is the adding auditory display to viual display likely to be most effective\n\n");
            Console.WriteLine("A. Emergency Department\n" +
                "B. Operatin Rooms\n" +
                "C. ICU\n" +
                "D. Pediatrics");
            string q11 = Console.ReadLine();
            if (q11.ToLower() == "b") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was B. Please refer to Question 81 on practice test 1.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q12()
        {
            //C Q76 PT1
            Console.WriteLine("In Which of the following is the study of the mind and the manner in which information is processed\n\n");
            Console.WriteLine("A. Communication science\n" +
                "B. Information science\n" +
                "C. Cognitive science\n" +
                "D. Social science");
            string q12 = Console.ReadLine();
            if (q12.ToLower() == "c") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was C. Please refer to Question 76 on practice test 1.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q13()
        {
            //B Q78 PT1
            Console.WriteLine("In Cognitive Work Analysis (CWA), the specified type of analysis that identifies the different \n" +
                "responsibilities of various users so HCI can support collaboration is:\n\n");
            Console.WriteLine("A. Strategies Analysis\n" +
                "B. Social Organization Analysis\n" +
                "C. Worker Compentencies Analysis\n" +
                "D. Control Task Analysis");
            string q13 = Console.ReadLine();
            if (q13.ToLower() == "b") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was B. Please refer to Question 78 on practice test 1.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q14()
        {
            //A Q87 PT1
            Console.WriteLine("Which of the following is part of the ANA's Informatics Nursing Specialist Standards of Practice\n\n");
            Console.WriteLine("A. Identification of issues / problems\n" +
                "B. Performance appraisal\n" +
                "C. Resources utilization\n" +
                "D. Collaboration");
            string q13 = Console.ReadLine();
            if (q13.ToLower() == "a") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was A. Please refer to Question 87 on practice test 1.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q15()
        {
            //D Q113 PT1
            Console.WriteLine("A method that can be used prior to utilizing a new procesds in order to identify and \n" +
                "correct problems in the process is:\n\n");
            Console.WriteLine("A. Six Sigma\n" +
                "B. Quality Improvement Process (QIP)\n" +
                "C. Focus,Analyze, Develop, Execute (FADE)\n" +
                "D. Failure, Mode, and Effects Analysis (FMEA)");
            string q13 = Console.ReadLine();
            if (q13.ToLower() == "d") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was D. Please refer to Question 113 on practice test 1.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q16()
        {
            //D Q102 PT1
            Console.WriteLine("To ensure network security, the best current WI-FI encryption is:\n\n");
            Console.WriteLine("A. WPA and AES\n" +
                "B. WPA2 and AES\n" +
                "C. WEP\n" +
                "D. WPA2 and TKIP");
            string q13 = Console.ReadLine();
            if (q13.ToLower() == "b") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was B. Please refer to Question 102 on practice test 1.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
        public int Q17()
        {
            //B Q115 PT1
            Console.WriteLine("The classification system presently used for mortality statistics is:\n\n");
            Console.WriteLine("A. ICD-9\n" +
                "B. ICD-10\n" +
                "C. ICD-10-CM\n" +
                "D. ICD-10-CM/PCS");
            string q13 = Console.ReadLine();
            if (q13.ToLower() == "b") return 10;
            else
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("The correct answer was B. Please refer to Question 115 on practice test 1.. Press Enter");
                Console.ReadKey();
                return 0;
            }
        }
    }
}
