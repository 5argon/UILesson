# Unity UI Animation Lesson

![Preview Gif](/READMEImages/previewgif.gif?raw=true "Preview")

A Unity project which you can use/hack to learn the basics of UI animation. I have been invited to teach anything Unity in my university so this is what we did in the class. I have added everything I want to say in the class here because I could not make it in time back then.

Probably require Unity v5.5+ because one student in the class could not open the scene in 5.3

## Live demo
[5argon.info/uilesson](http://5argon.info/uilesson)

## What is included

There are 2 scenes : GameplayScene and Menu.

GameplayScene has :
- LowerLeft(Health) : An example of in animation and out animation. The health also uses 9-slice sprite.
- UpperLeft(GPA) : How to use Mechanim's layer to add idle-animation in concurrent with in and out animation.

Menu has :
- BGGroup : Infinite scrolling BG technique + legacy animation clip
- LeftMenu : How to use Layout Group and Ignore Layout. You can animate these too!
- RightBluePanels : More kind of animations.

`ArtOfUIAnimations.pdf` is the slide I used in the class. It might be confusing since I mostly say things rather than putting words in the slide, but it contains images from various games so you can study from other game's UI. Be sure to check out a video on YouTube of these games too so you can learn about decision of UI animation. (Should I fade in or appear? Should I move linearly or ease-out? What is the best order to move UI to the view? etc.)

Throughout the project you will notice some messages which you can read :

![Screenshot 1](/READMEImages/ss1.png?raw=true "Screenshot 1")
![Screenshot 2](/READMEImages/ss2.png?raw=true "Screenshot 2")
![Screenshot 3](/READMEImages/ss3.png?raw=true "Screenshot 3")
![Screenshot 4](/READMEImages/ss4.png?raw=true "Screenshot 4")

## General Tips
- Without any Animator, position UIs in its "neutral" position first.
- Wait state is to hide the UI with setActive false or maybe move it outside of the screen to prepare for animation. When you make a state that will move the UI in you can copy the first frame from its Wait state, then tween that to the "neutral" state we made earlier.
- Default curve is Auto/Clamped Auto, in many cases this is not ideal for your game. Right click the keyframe to change it. Linear and Constant are powerful, do not underestimate them.
- For commading states you will be using Trigger. It is a special kind of boolean which becomes false when consumed by the state. Set the conditions by clicking on THE ARROW between states and scroll to the bottom.
- If you see strange animation that you are not expecting probably the transition duration is not 0. The default is 0.1, which means after the state ends it will blend 10% after then ending point with the next one. (This is why the default Exit Time is 0.9, so the state ends early at 90% and uses the last 10% for transition. For UIs, I usually do Exit Time 1 (100%) and Transition Duration 0 (0%))
- Loop or not must be set directly on the animation clip **file**. You will see "Loop Time".
- After you connected everything you can test the state flow without any commanding scripts by going into Play Mode and then click on the circle to the right of Trigger's name. If clicking does nothing, probably on the Animation Panel you have Record on. Turn that off first.
- To set Trigger from the script uses `animatorVariable.SetTrigger("TriggerName")
- If you tried to make animation layers but nothing happen, probably the weight is still 0. Click the little gear icon to the right of animation layer name to set the weight. (For UI it is usually 1)

## General Tips (Thai)
- ทำ UI เป็นสถานะกลางก่อน คือหลังจากเข้ามาเสร็จแล้วเป็นยังไง ใช้เป็นฐาน
- คลิกบน GO บนสุด สร้าง Animator + 1 Animation Clip โดยคลิกปุ่มใน Panel Animation
- สถานะ Wait คือซ่อนไว้ก่อน ถ้าจะซ่อนแบบ Set Active ก็ง่าย แต่ถ้าแบบหลบออกนอกจอก็ใช้ UI สถานะกลางที่ทำไว้เป็นจุดอ้างอิง พอจะทำ ComeIn แล้วก็แค่ก๊อปตำแหน่งจาก Wait มาไว้เป็น frame แรกของ ComeIn แล้วก็ animate มาสู่ตำแหน่งสถานะกลาง
- เวลา animate แล้วอย่าลืมว่า default มันเป็นโค้งๆ ถ้าคลิกขวาแล้วเลือก Both Tangent > Linear อะไรงี้จะเปลี่ยนเป็นเรียบๆได้ หรือถ้ากดเข้าหน้า Curves ข้างล่าง ก็จะปรับได้ละเอียดขึ้น
- แล้วไปสร้าง Trigger ใน Panel Animator มา
- คลิกขวาแล้วสร้าง Transition ได้
- อย่าลืมปรับ Transition Time เป็น 0 กับ Exit Time เป็น 1 (ไม่จำเป็นถ้ามี Condition เป็น Trigger แล้ว)
- ปรับการ Loop ได้ในไฟล์ Animation Clip ใน Panel Project จะมี Loop Time ให้ติ้กใน Inspector
- เมื่อเชื่อมทุกอย่างแล้ว ใน Play Mode สามารถคลิกตุ่ม Trigger ทดลองได้ ถ้าคลิกตุ่มแล้วมันไม่ไปส่วนมากเพราะลืมกดปุ่ม Record ออกในหน้า Animation
- ถ้าในสคริปต์ก็ animatorVariable.SetTrigger(“TriggerName”)
- ถ้าจะลองทำ Layer อย่าลืมกดตรงเฟืองแล้วตั้ง Weight เป็น 1
