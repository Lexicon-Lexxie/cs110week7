## 7A

(✓) Whiteboard - Lexxie & Niko

(✓) Prototype - Niko

(✓) Evidence - Lexxie

(✓) Writing contents for slideshow - Paulina

(✓) Finding Images for presentation - Rudy

(✓) Discord Response - Niko

(✓) Peer Review - Rudy

## 7B

Whiteboard - Niko

Github management - Lexxie

Template modification according to 7B - Lexxie

Final Prototype - Niko

AI Review - Rudy

Evidence collection - Paulina

## TODO

R1 / 7A / Plan for one reader
In GitHub Evidence/7A, keep the context, user story, whiteboard slide flow and visual prototype. Map text, images, slide order and buttons; label choices/sound optional.
Context: Greenward: A New Crew. Use clear interface language such as “Capture screen” and “Capture ready,” or equally clear labels.
Guide and code: https://courses.addp2p.com/assignments/cs110/week7/quick-start.html

R2 / 7A / Build and record 7A
Push the working WPF story app to GitHub: matched text/images, Next/Back/Restart, safe first/last slide and missing-image feedback. Keep notes, screenshots and peer/Discord evidence; submit the same-day Action 7A record.
Context: Greenward: A New Crew. Use clear interface language such as “Capture screen” and “Capture ready,” or equally clear labels.
Guide and code: https://courses.addp2p.com/assignments/cs110/week7/quick-start.html

R3 / 7B / Add screen capture
In the same GitHub WPF project, add primary-screen capture, preview, Save PNG and Clear. Test save-before-capture, save/cancel, clear/repeat and unchanged slide position. Keep the saved PNG and observed results.
Context: Greenward: A New Crew. Use clear interface language such as “Capture screen” and “Capture ready,” or equally clear labels.
Guide and code: https://courses.addp2p.com/assignments/cs110/week7/quick-start.html

R4 / 7B / Test and record 7B
Push the GitHub 7B checkpoint with whiteboard logic trace, lecture notes, screenshots, peer/Discord evidence and one required AI prompt/response/test/decision record. Submit the same-day Action 7B record.
Context: Greenward: A New Crew. Use clear interface language such as “Capture screen” and “Capture ready,” or equally clear labels.
Guide and code: https://courses.addp2p.com/assignments/cs110/week7/quick-start.html

R5 / WEEK / Explain and package
Put README, short tutorial presentation, image credits, Release-build result and tested source ZIP in GitHub. Another person extracts, builds and runs it; record their test and any repair. Reuse Action evidence.
Context: Greenward: A New Crew. Use clear interface language such as “Capture screen” and “Capture ready,” or equally clear labels.
Guide and code: https://courses.addp2p.com/assignments/cs110/week7/quick-start.html

R6 / WEEK / Submit one GitHub URL
Add this route receipt to GitHub Evidence/Final. Commit and push the final package, test instructor access and submit one tested GitHub repository URL through Canvas. Check the official deadline there.
Context: Greenward: A New Crew. Use clear interface language such as “Capture screen” and “Capture ready,” or equally clear labels.
Guide and code: https://courses.addp2p.com/assignments/cs110/week7/quick-start.html

### 7A TODO

whiteboard

Choose one context. Write “As a [reader], I want [action], so I can [purpose].” Sketch beginning → problem → ending; label Next, Back and Restart.

prototype

Arrange story text, image and buttons in PowerPoint, slides or a photo editor. Map each screen to its slide index (position), image filename and text. Mark branching and sound optional.

build

Follow guide 7A in the supplied template. Edit MainWindow.xaml for layout and the slides array in MainWindow.xaml.cs for content. Keep at least the three starter positions; replace their text and images for your context.

test

Trace button → event handler → ShowSlide. Try Back on the first slide, Next on the last, Restart and a missing image. Have a peer compare the app with the prototype.

keep

Save lecture notes, whiteboard photo, prototype, running screenshots and a concise peer/Discord result in Evidence/7A. Commit and push “7A story checkpoint” to GitHub; submit today’s Action record before leaving.

### 7B TODO

whiteboard

Trace Capture → bitmap → preview → Save or Cancel → Clear → repeat. Show which method returns an image and which event updates the WPF controls.

build

Follow guide 7B: add the supplied CaptureService.cs helper to the project; add the three controls inside the named XAML panel; put event handlers inside the MainWindow class. Use the lesson snippets, not an entire-project AI replacement.

test

Put the app on the primary display. Capture the visible slideshow, save a PNG, open it, cancel a second save, clear, capture again and navigate the story. Try Save before Capture. Record results and one correction with a peer.

ai

Use the supplied prompt or supplied-response exercise below. Run one proposed test; record prompt/response, observed result and keep/change/reject in Evidence/7B.

keep

Save lecture notes, logic trace, preview/saved-PNG screenshots, test record and concise Discord collaboration evidence. Commit and push “7B capture checkpoint” to GitHub; submit today’s Action record before leaving.

REQUIRED AI CHECK

Open one bounded prompt

Ask about one method or one test. Run the suggestion, then record what you kept, changed, or rejected.

I am adding screen capture to a beginner WPF C# slideshow app. Explain ONE method or propose ONE test for Capture, Save/Cancel, Clear, or keeping currentSlide unchanged. Do not rewrite the project. Name the file, method, input, output and result I should observe. Use fictional data only.

### FINAL TODO

prepare

Check R1–R6. Finish README.md: intended user, purpose, setup, controls, code map, test results, image credits, limitations and next step. Reuse Action evidence.

explain

Make a short tutorial presentation from that evidence: overview/user story, flowchart, prototype vs app, one code walkthrough, media/capture and contributions. Save editable slides and PDF in Evidence/Final.

build / package

Build Release. ZIP the complete source project with Assets, README and Evidence; omit bin, obj and .vs. Keep the ZIP under 100 MB for GitHub. This source package needs Visual Studio/.NET to run.

verify

Ask another person to extract the ZIP elsewhere, follow README, build and run it, navigate every slide, capture and save. Record their result or exact error, repair and retest.

hand off

Add the route receipt to Evidence/Final, commit and push the final files and ZIP to GitHub. Test instructor access. Submit one tested GitHub repository URL in Canvas by the day before the next class; check Canvas for the official deadline.
