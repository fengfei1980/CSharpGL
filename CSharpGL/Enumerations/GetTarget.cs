﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    public enum GetTarget : uint
    {
        CurrentColor = GL.GL_CURRENT_COLOR,
        CurrentIndex = GL.GL_CURRENT_INDEX,
        CurrentNormal = GL.GL_CURRENT_NORMAL,
        CurrentTextureCoords = GL.GL_CURRENT_TEXTURE_COORDS,
        CurrentRasterColor = GL.GL_CURRENT_RASTER_COLOR,
        CurrentRasterIndex = GL.GL_CURRENT_RASTER_INDEX,
        CurrentRasterTextureCoords = GL.GL_CURRENT_RASTER_TEXTURE_COORDS,
        CurrentRasterPosition = GL.GL_CURRENT_RASTER_POSITION,
        CurrentRasterPositionValid = GL.GL_CURRENT_RASTER_POSITION_VALID,
        CurrentRasterDistance = GL.GL_CURRENT_RASTER_DISTANCE,
        PointSmooth = GL.GL_POINT_SMOOTH,
        PointSize = GL.GL_POINT_SIZE,
        PointSizeRange = GL.GL_POINT_SIZE_RANGE,
        PointSizeGranularity = GL.GL_POINT_SIZE_GRANULARITY,
        LineSmooth = GL.GL_LINE_SMOOTH,
        LineWidth = GL.GL_LINE_WIDTH,
        LineWidthRange = GL.GL_LINE_WIDTH_RANGE,
        LineWidthGranularity = GL.GL_LINE_WIDTH_GRANULARITY,
        LineStipple = GL.GL_LINE_STIPPLE,
        LineStipplePattern = GL.GL_LINE_STIPPLE_PATTERN,
        LineStippleRepeat = GL.GL_LINE_STIPPLE_REPEAT,
        ListMode = GL.GL_LIST_MODE,
        MaxListNesting = GL.GL_MAX_LIST_NESTING,
        ListBase = GL.GL_LIST_BASE,
        ListIndex = GL.GL_LIST_INDEX,
        PolygonMode = GL.GL_POLYGON_MODE,
        PolygonSmooth = GL.GL_POLYGON_SMOOTH,
        PolygonStipple = GL.GL_POLYGON_STIPPLE,
        EdgeFlag = GL.GL_EDGE_FLAG,
        CullFace = GL.GL_CULL_FACE,
        CullFaceMode = GL.GL_CULL_FACE_MODE,
        FrontFace = GL.GL_FRONT_FACE,
        Lighting = GL.GL_LIGHTING,
        LightModelLocalViewer = GL.GL_LIGHT_MODEL_LOCAL_VIEWER,
        LightModelTwoSide = GL.GL_LIGHT_MODEL_TWO_SIDE,
        LightModelAmbient = GL.GL_LIGHT_MODEL_AMBIENT,
        ShadeModel = GL.GL_SHADE_MODEL,
        ColorMaterialFace = GL.GL_COLOR_MATERIAL_FACE,
        ColorMaterialParameter = GL.GL_COLOR_MATERIAL_PARAMETER,
        ColorMaterial = GL.GL_COLOR_MATERIAL,
        Fog = GL.GL_FOG,
        FogIndex = GL.GL_FOG_INDEX,
        FogDensity = GL.GL_FOG_DENSITY,
        FogStart = GL.GL_FOG_START,
        FogEnd = GL.GL_FOG_END,
        FogMode = GL.GL_FOG_MODE,
        FogColor = GL.GL_FOG_COLOR,
        DepthRange = GL.GL_DEPTH_RANGE,
        DepthTest = GL.GL_DEPTH_TEST,
        DepthWritemask = GL.GL_DEPTH_WRITEMASK,
        DepthClearValue = GL.GL_DEPTH_CLEAR_VALUE,
        DepthFunc = GL.GL_DEPTH_FUNC,
        AccumClearValue = GL.GL_ACCUM_CLEAR_VALUE,
        StencilTest = GL.GL_STENCIL_TEST,
        StencilClearValue = GL.GL_STENCIL_CLEAR_VALUE,
        StencilFunc = GL.GL_STENCIL_FUNC,
        StencilValueMask = GL.GL_STENCIL_VALUE_MASK,
        StencilFail = GL.GL_STENCIL_FAIL,
        StencilPassDepthFail = GL.GL_STENCIL_PASS_DEPTH_FAIL,
        StencilPassDepthPass = GL.GL_STENCIL_PASS_DEPTH_PASS,
        StencilRef = GL.GL_STENCIL_REF,
        StencilWritemask = GL.GL_STENCIL_WRITEMASK,
        MatrixMode = GL.GL_MATRIX_MODE,
        Normalize = GL.GL_NORMALIZE,
        Viewport = GL.GL_VIEWPORT,
        ModelviewStackDepth = GL.GL_MODELVIEW_STACK_DEPTH,
        ProjectionStackDepth = GL.GL_PROJECTION_STACK_DEPTH,
        TextureStackDepth = GL.GL_TEXTURE_STACK_DEPTH,
        ModelviewMatix = GL.GL_MODELVIEW_MATRIX,
        ProjectionMatrix = GL.GL_PROJECTION_MATRIX,
        TextureMatrix = GL.GL_TEXTURE_MATRIX,
        AttribStackDepth = GL.GL_ATTRIB_STACK_DEPTH,
        ClientAttribStackDepth = GL.GL_CLIENT_ATTRIB_STACK_DEPTH,
        AlphaTest = GL.GL_ALPHA_TEST,
        AlphaTestFunc = GL.GL_ALPHA_TEST_FUNC,
        AlphaTestRef = GL.GL_ALPHA_TEST_REF,
        Dither = GL.GL_DITHER,
        BlendDst = GL.GL_BLEND_DST,
        BlendSrc = GL.GL_BLEND_SRC,
        Blend = GL.GL_BLEND,
        LogicOpMode = GL.GL_LOGIC_OP_MODE,
        IndexLogicOp = GL.GL_INDEX_LOGIC_OP,
        ColorLogicOp = GL.GL_COLOR_LOGIC_OP,
        AuxBuffers = GL.GL_AUX_BUFFERS,
        DrawBuffer = GL.GL_DRAW_BUFFER,
        ReadBuffer = GL.GL_READ_BUFFER,
        ScissorBox = GL.GL_SCISSOR_BOX,
        ScissorTest = GL.GL_SCISSOR_TEST,
        IndexClearValue = GL.GL_INDEX_CLEAR_VALUE,
        IndexWritemask = GL.GL_INDEX_WRITEMASK,
        ColorClearValue = GL.GL_COLOR_CLEAR_VALUE,
        ColorWritemask = GL.GL_COLOR_WRITEMASK,
        IndexMode = GL.GL_INDEX_MODE,
        RgbaMode = GL.GL_RGBA_MODE,
        DoubleBuffer = GL.GL_DOUBLEBUFFER,
        Stereo = GL.GL_STEREO,
        RenderMode = GL.GL_RENDER_MODE,
        PerspectiveCorrectionHint = GL.GL_PERSPECTIVE_CORRECTION_HINT,
        PointSmoothHint = GL.GL_POINT_SMOOTH_HINT,
        LineSmoothHint = GL.GL_LINE_SMOOTH_HINT,
        PolygonSmoothHint = GL.GL_POLYGON_SMOOTH_HINT,
        FogHint = GL.GL_FOG_HINT,
        TextureGenS = GL.GL_TEXTURE_GEN_S,
        TextureGenT = GL.GL_TEXTURE_GEN_T,
        TextureGenR = GL.GL_TEXTURE_GEN_R,
        TextureGenQ = GL.GL_TEXTURE_GEN_Q,
        PixelMapItoI = GL.GL_PIXEL_MAP_I_TO_I,
        PixelMapStoS = GL.GL_PIXEL_MAP_S_TO_S,
        PixelMapItoR = GL.GL_PIXEL_MAP_I_TO_R,
        PixelMapItoG = GL.GL_PIXEL_MAP_I_TO_G,
        PixelMapItoB = GL.GL_PIXEL_MAP_I_TO_B,
        PixelMapItoA = GL.GL_PIXEL_MAP_I_TO_A,
        PixelMapRtoR = GL.GL_PIXEL_MAP_R_TO_R,
        PixelMapGtoG = GL.GL_PIXEL_MAP_G_TO_G,
        PixelMapBtoB = GL.GL_PIXEL_MAP_B_TO_B,
        PixelMapAtoA = GL.GL_PIXEL_MAP_A_TO_A,
        PixelMapItoISize = GL.GL_PIXEL_MAP_I_TO_I_SIZE,
        PixelMapStoSSize = GL.GL_PIXEL_MAP_S_TO_S_SIZE,
        PixelMapItoRSize = GL.GL_PIXEL_MAP_I_TO_R_SIZE,
        PixelMapItoGSize = GL.GL_PIXEL_MAP_I_TO_G_SIZE,
        PixelMapItoBSize = GL.GL_PIXEL_MAP_I_TO_B_SIZE,
        PixelMapItoASize = GL.GL_PIXEL_MAP_I_TO_A_SIZE,
        PixelMapRtoRSize = GL.GL_PIXEL_MAP_R_TO_R_SIZE,
        PixelMapGtoGSize = GL.GL_PIXEL_MAP_G_TO_G_SIZE,
        PixelMapBtoBSize = GL.GL_PIXEL_MAP_B_TO_B_SIZE,
        PixelMapAtoASize = GL.GL_PIXEL_MAP_A_TO_A_SIZE,
        UnpackSwapBytes = GL.GL_UNPACK_SWAP_BYTES,
        LsbFirst = GL.GL_UNPACK_LSB_FIRST,
        UnpackRowLength = GL.GL_UNPACK_ROW_LENGTH,
        UnpackSkipRows = GL.GL_UNPACK_SKIP_ROWS,
        UnpackSkipPixels = GL.GL_UNPACK_SKIP_PIXELS,
        UnpackAlignment = GL.GL_UNPACK_ALIGNMENT,
        PackSwapBytes = GL.GL_PACK_SWAP_BYTES,
        PackLsbFirst = GL.GL_PACK_LSB_FIRST,
        PackRowLength = GL.GL_PACK_ROW_LENGTH,
        PackSkipRows = GL.GL_PACK_SKIP_ROWS,
        PackSkipPixels = GL.GL_PACK_SKIP_PIXELS,
        PackAlignment = GL.GL_PACK_ALIGNMENT,
        MapColor = GL.GL_MAP_COLOR,
        MapStencil = GL.GL_MAP_STENCIL,
        IndexShift = GL.GL_INDEX_SHIFT,
        IndexOffset = GL.GL_INDEX_OFFSET,
        RedScale = GL.GL_RED_SCALE,
        RedBias = GL.GL_RED_BIAS,
        ZoomX = GL.GL_ZOOM_X,
        ZoomY = GL.GL_ZOOM_Y,
        GreenScale = GL.GL_GREEN_SCALE,
        GreenBias = GL.GL_GREEN_BIAS,
        BlueScale = GL.GL_BLUE_SCALE,
        BlueBias = GL.GL_BLUE_BIAS,
        AlphaScale = GL.GL_ALPHA_SCALE,
        AlphaBias = GL.GL_ALPHA_BIAS,
        DepthScale = GL.GL_DEPTH_SCALE,
        DepthBias = GL.GL_DEPTH_BIAS,
        MapEvalOrder = GL.GL_MAX_EVAL_ORDER,
        MaxLights = GL.GL_MAX_LIGHTS,
        MaxClipPlanes = GL.GL_MAX_CLIP_PLANES,
        MaxTextureSize = GL.GL_MAX_TEXTURE_SIZE,
        MapPixelMapTable = GL.GL_MAX_PIXEL_MAP_TABLE,
        MaxAttribStackDepth = GL.GL_MAX_ATTRIB_STACK_DEPTH,
        MaxModelviewStackDepth = GL.GL_MAX_MODELVIEW_STACK_DEPTH,
        MaxNameStackDepth = GL.GL_MAX_NAME_STACK_DEPTH,
        MaxProjectionStackDepth = GL.GL_MAX_PROJECTION_STACK_DEPTH,
        MaxTextureStackDepth = GL.GL_MAX_TEXTURE_STACK_DEPTH,
        MaxViewportDims = GL.GL_MAX_VIEWPORT_DIMS,
        MaxClientAttribStackDepth = GL.GL_MAX_CLIENT_ATTRIB_STACK_DEPTH,
        SubpixelBits = GL.GL_SUBPIXEL_BITS,
        IndexBits = GL.GL_INDEX_BITS,
        RedBits = GL.GL_RED_BITS,
        GreenBits = GL.GL_GREEN_BITS,
        BlueBits = GL.GL_BLUE_BITS,
        AlphaBits = GL.GL_ALPHA_BITS,
        DepthBits = GL.GL_DEPTH_BITS,
        StencilBits = GL.GL_STENCIL_BITS,
        AccumRedBits = GL.GL_ACCUM_RED_BITS,
        AccumGreenBits = GL.GL_ACCUM_GREEN_BITS,
        AccumBlueBits = GL.GL_ACCUM_BLUE_BITS,
        AccumAlphaBits = GL.GL_ACCUM_ALPHA_BITS,
        NameStackDepth = GL.GL_NAME_STACK_DEPTH,
        AutoNormal = GL.GL_AUTO_NORMAL,
        Map1Color4 = GL.GL_MAP1_COLOR_4,
        Map1Index = GL.GL_MAP1_INDEX,
        Map1Normal = GL.GL_MAP1_NORMAL,
        Map1TextureCoord1 = GL.GL_MAP1_TEXTURE_COORD_1,
        Map1TextureCoord2 = GL.GL_MAP1_TEXTURE_COORD_2,
        Map1TextureCoord3 = GL.GL_MAP1_TEXTURE_COORD_3,
        Map1TextureCoord4 = GL.GL_MAP1_TEXTURE_COORD_4,
        Map1Vertex3 = GL.GL_MAP1_VERTEX_3,
        Map1Vertex4 = GL.GL_MAP1_VERTEX_4,
        Map2Color4 = GL.GL_MAP2_COLOR_4,
        Map2Index = GL.GL_MAP2_INDEX,
        Map2Normal = GL.GL_MAP2_NORMAL,
        Map2TextureCoord1 = GL.GL_MAP2_TEXTURE_COORD_1,
        Map2TextureCoord2 = GL.GL_MAP2_TEXTURE_COORD_2,
        Map2TextureCoord3 = GL.GL_MAP2_TEXTURE_COORD_3,
        Map2TextureCoord4 = GL.GL_MAP2_TEXTURE_COORD_4,
        Map2Vertex3 = GL.GL_MAP2_VERTEX_3,
        Map2Vertex4 = GL.GL_MAP2_VERTEX_4,
        Map1GridDomain = GL.GL_MAP1_GRID_DOMAIN,
        Map1GridSegments = GL.GL_MAP1_GRID_SEGMENTS,
        Map2GridDomain = GL.GL_MAP2_GRID_DOMAIN,
        Map2GridSegments = GL.GL_MAP2_GRID_SEGMENTS,
        Texture1D = GL.GL_TEXTURE_1D,
        Texture2D = GL.GL_TEXTURE_2D,
        FeedbackBufferPointer = GL.GL_FEEDBACK_BUFFER_POINTER,
        FeedbackBufferSize = GL.GL_FEEDBACK_BUFFER_SIZE,
        FeedbackBufferType = GL.GL_FEEDBACK_BUFFER_TYPE,
        SelectionBufferPointer = GL.GL_SELECTION_BUFFER_POINTER,
        SelectionBufferSize = GL.GL_SELECTION_BUFFER_SIZE
    }	
}
