# mechanic-sim-xr

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Unity](https://img.shields.io/badge/Unity-2022.3%20%7C%206.0-black.svg)](#)
[![XR](https://img.shields.io/badge/XR-OpenXR%20%7C%20WebGL-cyan.svg)](#)

Interactive automotive and machinery maintenance simulator supporting VR headsets and lightweight browser WebGL.

```mermaid
graph TD
    A[XR Physics Hand Grab] --> B[Socket Interactor]
    B --> C[AssemblyGraph Hierarchy]
    C --> D[TorqueFastener Simulator]
    D --> E[Exploded View Animation Engine]
```

## Features

- **Dependency Graph Sequencing**: Enforces strict manufacturer service sequences (e.g., valve cover before camshaft removal).
- **Realistic Torque Simulation**: Haptic feedback on simulated torque wrenches with nominal tolerance verification.
- **Dual Runtime Target**: High-end OpenXR VR (Quest / Vive) or sub-25MB WebGL browser deployment.

## License

MIT License (c) 2023-2026 Gaurav Bhardwaj / OmegaGaze Lab.
