﻿using System;
using System.Runtime.InteropServices;

namespace DrkMgk
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryBasicInformation
    {
        public IntPtr BaseAddress;
        public IntPtr AllocationBase;
        public MemoryProtectionType AllocationProtect;
        public IntPtr RegionSize;
        public MemoryAllocationState State;
        public MemoryProtectionType Protect;
        public MemoryAllocationType Type;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SecurityAttributes
    {
        public int Length;
        public IntPtr SecurityDescriptor;
        public bool InheritHandle;
    }
}
