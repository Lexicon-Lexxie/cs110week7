### Folder & Deliverable Map Reference
```text
Week7/                              <-- ROOT FOLDER
├── README.md                       <-- Non-code documentation in root
├── Week7_Source.zip                <-- Final package in root (<100 MB; excludes bin, obj, .vs)
├── Evidence/                       <-- Evidence folders in root
│   ├── 7A/                         (✓ Complete: whiteboard photo, prototype, notes, screenshots, Discord proof)
│   ├── 7B/                         (whiteboard trace, AI record, test screenshots, saved PNGs, Discord proof)
│   └── Final/                      (tutorial slides .pptx & .pdf, peer verification log, route receipt)
└── StoryGameApp/                   <-- VS / C# PROJECT FILES ONLY
    ├── StoryGameApp.csproj
    ├── App.xaml / App.xaml.cs
    ├── MainWindow.xaml / MainWindow.xaml.cs
    ├── CaptureService.cs
    └── Assets/
        └── Images/                 (01.png, 02.png, 03.png, etc.)
```

---

## 1. Phase-by-Phase Checklist

### Phase 7A: Storyboard, Prototype & Core WPF Navigation (COMPLETE)
* [x] **Story & User Goal**: Formulated reader statement: *"As a [reader], I want [action], so I can [purpose]"* in the Greenward context.
* [x] **Whiteboard**: Sketched narrative flow (Beginning $\rightarrow$ Conflict $\rightarrow$ Resolution), labeled Next, Back, and Restart.
* [x] **Digital Prototype**: Built visual prototype (PowerPoint/slides/Figma) annotating slide indices (0, 1, 2), images, text, and buttons.
* [x] **Starter Setup**: Extracted into `Week7/StoryGameApp/` and verified clean .NET 10 WPF build.
* [x] **Content Integration**: Added PNG assets to `Week7/StoryGameApp/Assets/Images/` (Content/Copy to Output) and updated `slides` array in `MainWindow.xaml.cs`.
* [x] **Boundary & Error Testing**: Tested first slide (Back disabled/safe), last slide (Next disabled/safe), Restart, and missing-image feedback.
* [x] **7A Evidence & Checkpoint**: Saved whiteboard photo, prototype export, test screenshots, and Discord interaction into `Week7/Evidence/7A/`. Committed, pushed "7A story checkpoint", and submitted Action 7A.

---

### Phase 7B: Screen Capture Extension & AI Verification (IN PROGRESS)
* [ ] **Capture Whiteboard**: Draw trace diagram: `Capture` $\rightarrow$ `BitmapSource` $\rightarrow$ `Preview` $\rightarrow$ `Save / Cancel` $\rightarrow$ `Clear` $\rightarrow$ `Repeat`, verifying `currentSlide` remains unchanged.
* [ ] **Helper Integration**: Add `CaptureService.cs` into `Week7/StoryGameApp/` beside `MainWindow.xaml.cs` (namespace: `StoryGameApp`).
* [ ] **XAML Integration**: In `Week7/StoryGameApp/MainWindow.xaml`, replace empty `<StackPanel x:Name="CapturePanel"/>` with the capture controls inside the window layout.
* [ ] **Event Handlers**: Add `CaptureHandlers.cs.txt` methods and `capturedImage` field into `MainWindow.xaml.cs`.
* [ ] **Capture Testing**:
  * Save before Capture (must be disabled; no file generated).
  * Capture full primary screen $\rightarrow$ preview appears $\rightarrow$ `currentSlide` unchanged.
  * Cancel Save dialog $\rightarrow$ preview remains, no file created.
  * Save PNG $\rightarrow$ verify generated PNG can be opened outside app.
  * Clear $\rightarrow$ preview cleared, Save disabled.
* [ ] **Required AI Check**: Execute the bounded prompt or the supplied-response test; document Prompt, Response, Method/File, Observed Result, and Keep/Change/Reject decision.
* [ ] **7B Evidence & Checkpoint**: Save whiteboard trace, lecture notes, test logs, AI log, and Discord discussion to `Week7/Evidence/7B/`. Commit/push checkpoint, then submit Action 7B.

---

### Final Phase: Package, Peer Verification & Canvas Hand-off
* [ ] **Documentation (`README.md`)**: Complete all sections in root `Week7/README.md` (Intended User, Purpose, Setup, Controls, Code Map pointing to `StoryGameApp/`, Tests, Image Credits, Limitations, Next Steps, Contributions).
* [ ] **Tutorial Presentation**: Create tutorial slides (Overview, Flowchart, Prototype vs Final UI, Code Walkthrough, Capture Demo, Member roles). Export as editable presentation (.pptx) **and** PDF to `Week7/Evidence/Final/`.
* [ ] **Release Build**: Switch Visual Studio to **Release** configuration in `StoryGameApp` and build solution cleanly.
* [ ] **Clean Source ZIP**: Compress root `Week7/` into `.zip` (< 100 MB) containing `StoryGameApp/` source code and `Assets/`, root `README.md`, and root `Evidence/` (exclude `bin/`, `obj/`, and `.vs/`).
* [ ] **Independent Peer Verification**: Have an external peer clone/extract elsewhere, run instructions from root `README.md`, test navigation and screen capture, and record their results in `Week7/Evidence/Final/peer_verification.md`.
* [ ] **Receipt & Canvas Submission**: Place route receipt in `Week7/Evidence/Final/`. Push all final changes to GitHub, test repository permissions/visibility, and submit the single repository URL to Canvas.

---

## 2. Member-by-Member Master Checklist

### 💻 Lexxie — Lead Developer & Git Manager
- [x] **(✓) 7A**: Set up the WPF project inside `Week7/StoryGameApp/`; confirmed `.NET 10` builds and runs cleanly.
- [x] **(✓) 7A**: Verified XAML names match C# controls in `StoryGameApp/MainWindow.xaml` and `StoryGameApp/MainWindow.xaml.cs`.
- [x] **(✓) 7A**: Committed and pushed **"7A story checkpoint"** to GitHub; confirmed `Evidence/` is at root and code is in `StoryGameApp/`.
- [ ] **7B**: Integrate `CaptureService.cs` into `StoryGameApp/` and add the capture UI and handlers into `MainWindow.xaml` and `MainWindow.xaml.cs`.
- [ ] **7B**: Verify clean compilation with zero warnings/build errors.
- [ ] **7B**: Commit and push **"7B capture checkpoint"** to GitHub.
- [ ] **Final**: Perform the Visual Studio **Release Build** on `StoryGameApp`.
- [ ] **Final**: Package root files (`StoryGameApp/`, `Evidence/`, `README.md`) into a clean ZIP at root (excluding `bin/`, `obj/`, and `.vs/`; under 100 MB).
- [ ] **Final**: Ensure repository access/visibility is properly configured for instructor review and submit the tested URL.

---

### 🎨 Niko — Logic Architect & Visual Designer
- [x] **(✓) 7A**: Co-designed the 7A narrative whiteboard flow (Beginning $\rightarrow$ Problem $\rightarrow$ Ending) with the reader goal.
- [x] **(✓) 7A**: Built the digital visual prototype (PowerPoint/slides/Figma) annotating slide index (0, 1, 2), button positions, and image placements.
- [x] **(✓) 7A**: Posted prototype and progress to the team Discord channel; saved proof to `Week7/Evidence/7A/`.
- [ ] **7B**: Draw the 7B Whiteboard Logic Trace (`Capture` $\rightarrow$ `Bitmap` $\rightarrow$ `Preview` $\rightarrow$ `Save/Cancel` $\rightarrow$ `Clear`) demonstrating data flow and methods.
- [ ] **7B**: Update the digital prototype to reflect the new capture controls area (Capture, Save, Clear, Preview).
- [ ] **Final**: Code/Event walkthrough section for the tutorial: diagram how `ShowSlide(int index)` and `CaptureButton_Click` operate.
- [ ] **Final**: Co-verify UI scaling and alignment on the primary screen.

---

### 📝 Paulina — Narrative Writer & Documentation Lead
- [x] **(✓) 7A**: Wrote the Greenward storyline for Sana and the Tech crew across all 3 slides (clean narrative text, character context).
- [x] **(✓) 7A**: Formulated the formal user story: *"As a [reader], I want [action], so I can [purpose]"*.
- [x] **(✓) 7A**: Wrote informative alt/status descriptions for each slide to assist UI accessibility.
- [ ] **7B**: Collect Day 7B lecture notes and organize the evidence files inside `Week7/Evidence/7B/`.
- [ ] **Final**: Draft the comprehensive root `Week7/README.md` (Intended User, Purpose, Setup, Controls, Code Map showing `StoryGameApp/`, Known Limitations, Member Contributions).
- [ ] **Final**: Build the tutorial presentation slide deck covering user story, prototype vs final app, and test results.
- [ ] **Final**: Export presentation as both `.pptx` and `.pdf` into `Week7/Evidence/Final/`.

---

### 🔍 Rudy — Asset Pipeline, QA Tester & AI Lead
- [x] **(✓) 7A**: Sourced and formatted all story images as PNG files; verified standard dimensions and placed in `Week7/StoryGameApp/Assets/Images/`.
- [x] **(✓) 7A**: Performed boundary testing: tested `ShowSlide(0)` Back guard, last slide Next guard, Restart, and missing-image feedback.
- [x] **(✓) 7A**: Documented 7A test results table (`Test` / `Expected` / `Observed` / `Decision`) with screenshots in `Week7/Evidence/7A/`.
- [ ] **7B**: Conduct 7B functional tests (Save before Capture disabled, Capture preview, Save dialog Cancel vs Save, Clear preview, repeat capture, `currentSlide` unchanged).
- [ ] **7B**: Execute the **Required AI Check** (run bounded prompt or supplied-response scenario, record prompt/response/result/decision in `Week7/Evidence/7B/`).
- [ ] **Final**: Compile image and source credits table for all external assets used.
- [ ] **Final**: Coordinate the **Independent Peer Verification**: have an outside peer extract the release ZIP, run the app following root `README.md`, and log their verification notes in `Week7/Evidence/Final/peer_verification.md`.
