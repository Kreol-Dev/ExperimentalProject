namespace generators {
    
    
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable0 = ((Space)root.GetComponent(typeof(Space))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar3 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop2 = StoredVariable0.Places; //IsContext = False IsNew = False
				if(prop2 != null)
				{
					OperandVar3 = prop2;
				}
				
				
				if(ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar4 = applicable;
				}
			}
			return (System.Boolean) (OperandVar4);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Space subContext5 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				//ContextStatement Space subContext5 ContextSwitchInterpreter
				if(subContext5 != null)
				{
					
					subContext5.Size = (System.Int32)( (5f));
					System.Single OperandVar7 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop6 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar7 = prop6;
					for (int i = 0; i <  (OperandVar7); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc8 = loc; //IsContext = True IsNew = False
							Entity AddContext9 = (Entity)loc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Place AddContext10 = (Place)loc.AddComponent(typeof(Place)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Place AddContext10 ContextSwitchInterpreter
								if(AddContext10 != null)
								{
									System.Single OperandVar12 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop11 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar12 = prop11;
									AddContext10.Size = (System.Int32)( (OperandVar12));
								}
							}
							Named AddContext13 = (Named)loc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext13 ContextSwitchInterpreter
								if(AddContext13 != null)
								{
									
									
									
									AddContext13.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Location of: ")).ToString());
									
									
									System.String OperandVar15 = default(System.String); //IsContext = False IsNew = False
									System.String prop14 = External.RandomName(); //IsContext = False IsNew = False
									if(prop14 != null)
									{
										OperandVar15 = prop14;
									}
									AddContext13.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar15)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar17 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable16 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable16 != null)
						{
							OperandVar17 = StoredVariable16;
						}
						subContext5.Attach((Place)( (OperandVar17)));
					}
				}
			}
		}
        }
    }
    
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar31 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable18 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable18 != null)
			{
				System.Boolean ifResult19; //IsContext = False IsNew = False
				
				System.Boolean OperandVar26 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop20 = StoredVariable18.ShowedObject; //IsContext = False IsNew = False
				if(prop20 != null)
				{
					System.Boolean ifResult21; //IsContext = False IsNew = False
					System.Boolean OperandVar25 = default(System.Boolean); //IsContext = False IsNew = False
					Named OperandVar23 = default(Named); //IsContext = False IsNew = False
					Named StoredVariable22 = ((Named)prop20.GetComponent(typeof(Named))); //IsContext = False IsNew = False
					if(StoredVariable22 != null)
					{
						OperandVar23 = StoredVariable22;
					}
					System.Boolean prop24 = External.Has( (OperandVar23)); //IsContext = False IsNew = False
					OperandVar25 = prop24;
					if(ifResult21 =  (OperandVar25))
					{
						OperandVar26 = ifResult21;
					}
				}
				
				System.Boolean OperandVar30 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.named_ui_marker OperandVar28 = default(Blackboards.named_ui_marker); //IsContext = False IsNew = False
				Blackboards.named_ui_marker StoredVariable27 = ((Blackboards.named_ui_marker)StoredVariable18.GetComponent(typeof(Blackboards.named_ui_marker))); //IsContext = False IsNew = False
				if(StoredVariable27 != null)
				{
					OperandVar28 = StoredVariable27;
				}
				System.Boolean prop29 = External.Has( (OperandVar28)); //IsContext = False IsNew = False
				OperandVar30 = prop29;
				if(ifResult19 = ( ( (OperandVar26))) && ( (!(OperandVar30))))
				{
					applicable = true;
					OperandVar31 = applicable;
				}
			}
			return (System.Boolean) (OperandVar31);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.named_ui_marker>();
			
			{
				UiObject subContext32 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext32 ContextSwitchInterpreter
				if(subContext32 != null)
				{
					Named OperandVar35 = default(Named); //IsContext = False IsNew = False
					UnityEngine.GameObject prop33 = subContext32.ShowedObject; //IsContext = False IsNew = False
					if(prop33 != null)
					{
						Named StoredVariable34 = ((Named)prop33.GetComponent(typeof(Named))); //IsContext = False IsNew = False
						if(StoredVariable34 != null)
						{
							OperandVar35 = StoredVariable34;
						}
					}
					Named showed_named =  (OperandVar35); //IsContext = False IsNew = False
					TextField ContextVar36 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar36 ContextSwitchInterpreter
						if(ContextVar36 != null)
						{
							System.String OperandVar38 = default(System.String); //IsContext = False IsNew = False
							System.String prop37 = showed_named.FullName; //IsContext = False IsNew = False
							if(prop37 != null)
							{
								OperandVar38 = prop37;
							}
							ContextVar36.Show(( (OperandVar38)).ToString());
							
							{
								//ContextStatement Named showed_named ContextSwitchInterpreter
								if(showed_named != null)
								{
									VoidDelegate Lambda39 = () => 
									{
										System.String OperandVar41 = default(System.String); //IsContext = False IsNew = False
										System.String prop40 = showed_named.FullName; //IsContext = False IsNew = False
										if(prop40 != null)
										{
											OperandVar41 = prop40;
										}
										ContextVar36.Show(( (OperandVar41)).ToString());
									};
									showed_named.OnUpdate(Lambda39);
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext42 = ContextVar36.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext42 ContextPropertySwitchInterpreter
								if(subContext42 != null)
								{
									
									subContext42.minHeight = (System.Single)( (20f));
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    public class place_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar56 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable43 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable43 != null)
			{
				UiObject StoredVariable44 = ((UiObject)StoredVariable43.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
				if(StoredVariable44 != null)
				{
					System.Boolean ifResult45; //IsContext = False IsNew = False
					
					System.Boolean OperandVar52 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject prop46 = StoredVariable44.ShowedObject; //IsContext = False IsNew = False
					if(prop46 != null)
					{
						System.Boolean ifResult47; //IsContext = False IsNew = False
						System.Boolean OperandVar51 = default(System.Boolean); //IsContext = False IsNew = False
						Place OperandVar49 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable48 = ((Place)prop46.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable48 != null)
						{
							OperandVar49 = StoredVariable48;
						}
						System.Boolean prop50 = External.Has( (OperandVar49)); //IsContext = False IsNew = False
						OperandVar51 = prop50;
						if(ifResult47 =  (OperandVar51))
						{
							OperandVar52 = ifResult47;
						}
					}
					
					System.Boolean OperandVar55 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar53 = default(System.String); //IsContext = False IsNew = False
					OperandVar53 = "place_ui_set";
					System.Boolean prop54 = StoredVariable43.HasMarker( (OperandVar53)); //IsContext = False IsNew = False
					OperandVar55 = prop54;
					if(ifResult45 = ( ( (OperandVar52))) && ( (!(OperandVar55))))
					{
						applicable = true;
						OperandVar56 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar56);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext57 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext57 ContextSwitchInterpreter
				if(subContext57 != null)
				{
					System.String OperandVar58 = default(System.String); //IsContext = False IsNew = False
					OperandVar58 = "place_ui_set";
					subContext57.SetMarker(( (OperandVar58)).ToString());
				}
			}
			
			{
				UiObject subContext59 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext59 ContextSwitchInterpreter
				if(subContext59 != null)
				{
					Place OperandVar62 = default(Place); //IsContext = False IsNew = False
					UnityEngine.GameObject prop60 = subContext59.ShowedObject; //IsContext = False IsNew = False
					if(prop60 != null)
					{
						Place StoredVariable61 = ((Place)prop60.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable61 != null)
						{
							OperandVar62 = StoredVariable61;
						}
					}
					Place pl =  (OperandVar62); //IsContext = False IsNew = False
					Blackboards.place_ui_data puidata = root.AddComponent<Blackboards.place_ui_data>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
						if(puidata != null)
						{
							System.Int32 OperandVar64 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop63 = pl.Size; //IsContext = False IsNew = False
							OperandVar64 = prop63;
							puidata.LastSize = (System.Int32)( (OperandVar64));
						}
					}
					TextField ContextVar65 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar65 ContextSwitchInterpreter
						if(ContextVar65 != null)
						{
							System.Int32 OperandVar67 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop66 = pl.Size; //IsContext = False IsNew = False
							OperandVar67 = prop66;
							ContextVar65.Show(( (OperandVar67)).ToString());
							System.Boolean OperandVar71 = default(System.Boolean); //IsContext = False IsNew = False
							Updated OperandVar69 = default(Updated); //IsContext = False IsNew = False
							Updated StoredVariable68 = ((Updated)ContextVar65.GetComponent(typeof(Updated))); //IsContext = False IsNew = False
							if(StoredVariable68 != null)
							{
								OperandVar69 = StoredVariable68;
							}
							System.Boolean prop70 = External.Has( (OperandVar69)); //IsContext = False IsNew = False
							OperandVar71 = prop70;
							if(!(OperandVar71))
							{
								root.AddComponent<Updated>();
							}
							
							{
								//ContextStatement TextField ContextVar65 ContextSwitchInterpreter
								if(ContextVar65 != null)
								{
									
									ContextVar65.Label = (System.String)( ("size"));
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext72 = ContextVar65.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext72 ContextPropertySwitchInterpreter
								if(subContext72 != null)
								{
									
									subContext72.minHeight = (System.Single)( (20f));
								}
							}
							
							{
								Updated subContext73 = (Updated)root.GetComponent(typeof(Updated)); //IsContext = True IsNew = False
								//ContextStatement Updated subContext73 ContextSwitchInterpreter
								if(subContext73 != null)
								{
									BoolDelegate Lambda74 = () => 
									{
										System.Boolean return_value = default(System.Boolean); //IsContext = False IsNew = False
										
										{
											//ContextStatement Place pl ContextSwitchInterpreter
											if(pl != null)
											{
												
												{
													//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
													if(puidata != null)
													{
														
														
														System.Int32 OperandVar76 = default(System.Int32); //IsContext = False IsNew = False
														if(pl != null)
														{
															System.Int32 prop75 = pl.Size; //IsContext = False IsNew = False
															OperandVar76 = prop75;
														}
														
														System.Int32 OperandVar78 = default(System.Int32); //IsContext = False IsNew = False
														if(puidata != null)
														{
															System.Int32 prop77 = puidata.LastSize; //IsContext = False IsNew = False
															OperandVar78 = prop77;
														}
														if(!(( ( (OperandVar76))) == ( ( (OperandVar78)))))
														{
															System.Int32 OperandVar80 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop79 = pl.Size; //IsContext = False IsNew = False
																OperandVar80 = prop79;
															}
															puidata.LastSize = (System.Int32)( (OperandVar80));
															System.Int32 OperandVar82 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop81 = pl.Size; //IsContext = False IsNew = False
																OperandVar82 = prop81;
															}
															ContextVar65.Show(( (OperandVar82)).ToString());
														}
													}
												}
											}
										}
										return return_value;
									};
									subContext73.OnUpdate(Lambda74);
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar91 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable83 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable83 != null)
			{
				Place StoredVariable84 = ((Place)StoredVariable83.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable84 != null)
				{
					System.Boolean ifResult85; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar87 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop86 = StoredVariable84.Agents; //IsContext = False IsNew = False
					if(prop86 != null)
					{
						OperandVar87 = prop86;
					}
					
					
					
					System.Boolean OperandVar90 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar88 = default(System.String); //IsContext = False IsNew = False
					OperandVar88 = "agents_pool";
					System.Boolean prop89 = StoredVariable83.HasMarker( (OperandVar88)); //IsContext = False IsNew = False
					OperandVar90 = prop89;
					if(ifResult85 = ( (( ( (OperandVar87 != null ? OperandVar87.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar90))))
					{
						applicable = true;
						OperandVar91 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar91);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext92 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext92 ContextSwitchInterpreter
				if(subContext92 != null)
				{
					
					subContext92.Size = (System.Int32)( (5f));
					System.Single OperandVar94 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop93 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar94 = prop93;
					for (int i = 0; i <  (OperandVar94); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag95 = ag; //IsContext = True IsNew = False
							Entity AddContext96 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext97 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext98 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext98 ContextSwitchInterpreter
								if(AddContext98 != null)
								{
									System.Single OperandVar100 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop99 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar100 = prop99;
									AddContext98.Age = (System.Int32)( (OperandVar100));
								}
							}
							Named AddContext101 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext101 ContextSwitchInterpreter
								if(AddContext101 != null)
								{
									
									
									
									AddContext101.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar103 = default(System.String); //IsContext = False IsNew = False
									System.String prop102 = External.RandomName(); //IsContext = False IsNew = False
									if(prop102 != null)
									{
										OperandVar103 = prop102;
									}
									AddContext101.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar103)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar105 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable104 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable104 != null)
						{
							OperandVar105 = StoredVariable104;
						}
						subContext92.Attach((Agent)( (OperandVar105)));
					}
				}
			}
		}
        }
    }
    
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar112 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable106 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable106 != null)
			{
				System.Boolean ifResult107; //IsContext = False IsNew = False
				System.Boolean OperandVar111 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar109 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable108 = ((Blackboards.event_marker)StoredVariable106.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable108 != null)
				{
					OperandVar109 = StoredVariable108;
				}
				System.Boolean prop110 = External.Has( (OperandVar109)); //IsContext = False IsNew = False
				OperandVar111 = prop110;
				if(ifResult107 = !(OperandVar111))
				{
					applicable = true;
					OperandVar112 = applicable;
				}
			}
			return (System.Boolean) (OperandVar112);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.event_marker>();
		}
        }
    }
    
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar119 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable113 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable113 != null)
			{
				System.Boolean ifResult114; //IsContext = False IsNew = False
				System.Boolean OperandVar118 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar116 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable115 = ((Blackboards.personality)StoredVariable113.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable115 != null)
				{
					OperandVar116 = StoredVariable115;
				}
				System.Boolean prop117 = External.Has( (OperandVar116)); //IsContext = False IsNew = False
				OperandVar118 = prop117;
				if(ifResult114 = !(OperandVar118))
				{
					applicable = true;
					OperandVar119 = applicable;
				}
			}
			return (System.Boolean) (OperandVar119);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.personality>();
		}
        }
    }
    
    public class aged_generation_add : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar126 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable120 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable120 != null)
			{
				System.Boolean ifResult121; //IsContext = False IsNew = False
				System.Boolean OperandVar125 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar123 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable122 = ((Blackboards.aged_generation)StoredVariable120.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable122 != null)
				{
					OperandVar123 = StoredVariable122;
				}
				System.Boolean prop124 = External.Has( (OperandVar123)); //IsContext = False IsNew = False
				OperandVar125 = prop124;
				if(ifResult121 = !(OperandVar125))
				{
					applicable = true;
					OperandVar126 = applicable;
				}
			}
			return (System.Boolean) (OperandVar126);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.aged_generation>();
		}
        }
    }
    
    public class historical_persons : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar136 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable127 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable127 != null)
			{
				Lore StoredVariable128 = ((Lore)StoredVariable127.GetComponent(typeof(Lore))); //IsContext = False IsNew = False
				if(StoredVariable128 != null)
				{
					Place StoredVariable129 = ((Place)StoredVariable128.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable129 != null)
					{
						System.Boolean ifResult130; //IsContext = False IsNew = False
						
						
						System.Collections.Generic.List<Agent> OperandVar132 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
						System.Collections.Generic.List<Agent> prop131 = StoredVariable129.Agents; //IsContext = False IsNew = False
						if(prop131 != null)
						{
							OperandVar132 = prop131;
						}
						
						
						
						System.Boolean OperandVar135 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar133 = default(System.String); //IsContext = False IsNew = False
						OperandVar133 = "lore_pool";
						System.Boolean prop134 = StoredVariable127.HasMarker( (OperandVar133)); //IsContext = False IsNew = False
						OperandVar135 = prop134;
						if(ifResult130 = ( (( ( (OperandVar132 != null ? OperandVar132.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar135))))
						{
							applicable = true;
							OperandVar136 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar136);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext137 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext137 ContextSwitchInterpreter
				if(subContext137 != null)
				{
					
					subContext137.Size = (System.Int32)( (10f));
					System.Single OperandVar139 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop138 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
					OperandVar139 = prop138;
					for (int i = 0; i <  (OperandVar139); i++)
					{
						UnityEngine.GameObject old_ag = new UnityEngine.GameObject("old_ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject old_ag140 = old_ag; //IsContext = True IsNew = False
							Entity AddContext141 = (Entity)old_ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext142 = (Agent)old_ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.historical_person AddContext143 = (Blackboards.historical_person)old_ag.AddComponent(typeof(Blackboards.historical_person)); //IsContext = True IsNew = True
							Blackboards.human AddContext144 = (Blackboards.human)old_ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext144 ContextSwitchInterpreter
								if(AddContext144 != null)
								{
									System.Single OperandVar146 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop145 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar146 = prop145;
									AddContext144.Age = (System.Int32)( (OperandVar146));
								}
							}
							Named AddContext147 = (Named)old_ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext147 ContextSwitchInterpreter
								if(AddContext147 != null)
								{
									
									
									
									AddContext147.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Historical person: ")).ToString());
									
									
									System.String OperandVar149 = default(System.String); //IsContext = False IsNew = False
									System.String prop148 = External.RandomName(); //IsContext = False IsNew = False
									if(prop148 != null)
									{
										OperandVar149 = prop148;
									}
									AddContext147.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar149)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(old_ag);
						Agent OperandVar151 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable150 = ((Agent)old_ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable150 != null)
						{
							OperandVar151 = StoredVariable150;
						}
						subContext137.Attach((Agent)( (OperandVar151)));
					}
				}
			}
		}
        }
    }
    
    public class change_name_historical_action : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar161 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable152 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable152 != null)
			{
				Blackboards.historical_person StoredVariable153 = ((Blackboards.historical_person)StoredVariable152.GetComponent(typeof(Blackboards.historical_person))); //IsContext = False IsNew = False
				if(StoredVariable153 != null)
				{
					Named StoredVariable154 = ((Named)StoredVariable153.GetComponent(typeof(Named))); //IsContext = False IsNew = False
					if(StoredVariable154 != null)
					{
						Agent StoredVariable155 = ((Agent)StoredVariable154.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable155 != null)
						{
							System.Boolean ifResult156; //IsContext = False IsNew = False
							
							
							System.Boolean OperandVar158 = default(System.Boolean); //IsContext = False IsNew = False
							System.Boolean prop157 = StoredVariable155.Act; //IsContext = False IsNew = False
							OperandVar158 = prop157;
							
							
							
							System.Boolean OperandVar160 = default(System.Boolean); //IsContext = False IsNew = False
							if(StoredVariable152 != null)
							{
								System.Boolean prop159 = StoredVariable152.Dead; //IsContext = False IsNew = False
								OperandVar160 = prop159;
							}
							if(ifResult156 = ( (( ( (OperandVar158))) == ( ( (true))))) && ( (!(OperandVar160))))
							{
								applicable = true;
								OperandVar161 = applicable;
							}
						}
					}
				}
			}
			return (System.Boolean) (OperandVar161);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.5f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext162 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext162 ContextSwitchInterpreter
				if(subContext162 != null)
				{
					
					System.String OperandVar164 = default(System.String); //IsContext = False IsNew = False
					System.String prop163 = External.RandomName(); //IsContext = False IsNew = False
					if(prop163 != null)
					{
						OperandVar164 = prop163;
					}
					subContext162.Switch(( ("main_name")).ToString(),( (OperandVar164)).ToString());
				}
			}
		}
        }
    }
    
    public class location_log : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar170 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable165 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable165 != null)
			{
				Named StoredVariable166 = ((Named)StoredVariable165.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable166 != null)
				{
					System.Boolean ifResult167; //IsContext = False IsNew = False
					
					System.Boolean OperandVar169 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable165 != null)
					{
						System.Boolean prop168 = StoredVariable165.Act; //IsContext = False IsNew = False
						OperandVar169 = prop168;
					}
					
					
					if(ifResult167 = ( ( (OperandVar169))) == ( ( (true))))
					{
						applicable = true;
						OperandVar170 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar170);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.3f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			System.String OperandVar174 = default(System.String); //IsContext = False IsNew = False
			Named StoredVariable171 = ((Named)root.GetComponent(typeof(Named))); //IsContext = False IsNew = False
			if(StoredVariable171 != null)
			{
				System.String OperandVar172 = default(System.String); //IsContext = False IsNew = False
				OperandVar172 = "main_name";
				System.String prop173 = StoredVariable171.Get( (OperandVar172)); //IsContext = False IsNew = False
				if(prop173 != null)
				{
					OperandVar174 = prop173;
				}
			}
			External.Log((System.Object)( (OperandVar174)));
		}
        }
    }
    
    public class destroy_self : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar182 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable175 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable175 != null)
			{
				Agent StoredVariable176 = ((Agent)StoredVariable175.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
				if(StoredVariable176 != null)
				{
					System.Boolean ifResult177; //IsContext = False IsNew = False
					
					
					System.Boolean OperandVar179 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop178 = StoredVariable176.Act; //IsContext = False IsNew = False
					OperandVar179 = prop178;
					
					
					
					System.Boolean OperandVar181 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable175 != null)
					{
						System.Boolean prop180 = StoredVariable175.Dead; //IsContext = False IsNew = False
						OperandVar181 = prop180;
					}
					if(ifResult177 = ( (( ( (OperandVar179))) == ( ( (true))))) && ( (!(OperandVar181))))
					{
						applicable = true;
						OperandVar182 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar182);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.01f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			
			
			UnityEngine.GameObject OperandVar183 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar183 = root;
			External.Log((System.Object)(( ( ("Destroying self "))) + ( ( (OperandVar183)))));
			UnityEngine.GameObject OperandVar184 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar184 = root;
			External.Destroy((UnityEngine.Object)( (OperandVar184)));
		}
        }
    }
    
    public class story_start : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar193 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable185 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable185 != null)
			{
				System.Boolean ifResult186; //IsContext = False IsNew = False
				
				System.Boolean OperandVar189 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar187 = default(System.String); //IsContext = False IsNew = False
				OperandVar187 = "init_node";
				System.Boolean prop188 = StoredVariable185.HasMarker( (OperandVar187)); //IsContext = False IsNew = False
				OperandVar189 = prop188;
				
				System.Boolean OperandVar192 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar190 = default(System.String); //IsContext = False IsNew = False
				OperandVar190 = "story_set";
				System.Boolean prop191 = StoredVariable185.HasMarker( (OperandVar190)); //IsContext = False IsNew = False
				OperandVar192 = prop191;
				if(ifResult186 = ( ( (OperandVar189))) && ( (!(OperandVar192))))
				{
					applicable = true;
					OperandVar193 = applicable;
				}
			}
			return (System.Boolean) (OperandVar193);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext194 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext194 ContextSwitchInterpreter
				if(subContext194 != null)
				{
					System.String OperandVar195 = default(System.String); //IsContext = False IsNew = False
					OperandVar195 = "story_set";
					subContext194.SetMarker(( (OperandVar195)).ToString());
				}
			}
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node196 = s_node; //IsContext = True IsNew = False
				TaleNode AddContext197 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.story_node AddContext198 = (Blackboards.story_node)s_node.AddComponent(typeof(Blackboards.story_node)); //IsContext = True IsNew = True
				Markers AddContext199 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			
			{
				UnityEngine.GameObject subContext200 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext200 ContextPropertySwitchInterpreter
				if(subContext200 != null)
				{
					
					{
						TaleNode subContext201 = (TaleNode)subContext200.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext201 ContextSwitchInterpreter
						if(subContext201 != null)
						{
							
							subContext201.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class story_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar211 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable202 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable202 != null)
			{
				Blackboards.story_node StoredVariable203 = ((Blackboards.story_node)StoredVariable202.GetComponent(typeof(Blackboards.story_node))); //IsContext = False IsNew = False
				if(StoredVariable203 != null)
				{
					TaleNode StoredVariable204 = ((TaleNode)StoredVariable203.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable204 != null)
					{
						System.Boolean ifResult205; //IsContext = False IsNew = False
						
						System.Boolean OperandVar208 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar206 = default(System.String); //IsContext = False IsNew = False
						OperandVar206 = "decomposed";
						System.Boolean prop207 = StoredVariable202.HasMarker( (OperandVar206)); //IsContext = False IsNew = False
						OperandVar208 = prop207;
						
						System.Boolean OperandVar210 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop209 = StoredVariable204.IsActive; //IsContext = False IsNew = False
						OperandVar210 = prop209;
						if(ifResult205 = ( (!(OperandVar208))) && ( ( (OperandVar210))))
						{
							applicable = true;
							OperandVar211 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar211);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext212 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext212 ContextSwitchInterpreter
				if(subContext212 != null)
				{
					System.String OperandVar213 = default(System.String); //IsContext = False IsNew = False
					OperandVar213 = "decomposed";
					subContext212.SetMarker(( (OperandVar213)).ToString());
				}
			}
			UnityEngine.GameObject c_node = new UnityEngine.GameObject("c_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_node214 = c_node; //IsContext = True IsNew = False
				Markers AddContext215 = (Markers)c_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext216 = (TaleNode)c_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.conflict_node AddContext217 = (Blackboards.conflict_node)c_node.AddComponent(typeof(Blackboards.conflict_node)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_node);
			UnityEngine.GameObject c_r_node = new UnityEngine.GameObject("c_r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_r_node218 = c_r_node; //IsContext = True IsNew = False
				Markers AddContext219 = (Markers)c_r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext220 = (TaleNode)c_r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.conflict_resolution_node AddContext221 = (Blackboards.conflict_resolution_node)c_r_node.AddComponent(typeof(Blackboards.conflict_resolution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.conflict_resolution_node AddContext221 ContextSwitchInterpreter
					if(AddContext221 != null)
					{
						UnityEngine.GameObject OperandVar222 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar222 = c_node;
						AddContext221.Conflict = (UnityEngine.GameObject)( (OperandVar222));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_r_node);
			UnityEngine.GameObject r_node = new UnityEngine.GameObject("r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject r_node223 = r_node; //IsContext = True IsNew = False
				Markers AddContext224 = (Markers)r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext225 = (TaleNode)r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.result_node AddContext226 = (Blackboards.result_node)r_node.AddComponent(typeof(Blackboards.result_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.result_node AddContext226 ContextSwitchInterpreter
					if(AddContext226 != null)
					{
						UnityEngine.GameObject OperandVar227 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar227 = c_r_node;
						AddContext226.Resolution = (UnityEngine.GameObject)( (OperandVar227));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(r_node);
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node228 = s_node; //IsContext = True IsNew = False
				Markers AddContext229 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext230 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.solution_node AddContext231 = (Blackboards.solution_node)s_node.AddComponent(typeof(Blackboards.solution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.solution_node AddContext231 ContextSwitchInterpreter
					if(AddContext231 != null)
					{
						UnityEngine.GameObject OperandVar232 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar232 = c_r_node;
						AddContext231.Cause = (UnityEngine.GameObject)( (OperandVar232));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			UnityEngine.GameObject cris_node = new UnityEngine.GameObject("cris_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject cris_node233 = cris_node; //IsContext = True IsNew = False
				Markers AddContext234 = (Markers)cris_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext235 = (TaleNode)cris_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.crisis_node AddContext236 = (Blackboards.crisis_node)cris_node.AddComponent(typeof(Blackboards.crisis_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.crisis_node AddContext236 ContextSwitchInterpreter
					if(AddContext236 != null)
					{
						UnityEngine.GameObject OperandVar237 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar237 = s_node;
						AddContext236.Solution = (UnityEngine.GameObject)( (OperandVar237));
						UnityEngine.GameObject OperandVar238 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar238 = r_node;
						AddContext236.Cause = (UnityEngine.GameObject)( (OperandVar238));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(cris_node);
			
			{
				UnityEngine.GameObject subContext239 = c_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext239 ContextPropertySwitchInterpreter
				if(subContext239 != null)
				{
					
					{
						TaleNode subContext240 = (TaleNode)subContext239.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext240 ContextSwitchInterpreter
						if(subContext240 != null)
						{
							
							subContext240.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext241 = c_r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext241 ContextPropertySwitchInterpreter
				if(subContext241 != null)
				{
					
					{
						TaleNode subContext242 = (TaleNode)subContext241.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext242 ContextSwitchInterpreter
						if(subContext242 != null)
						{
							
							subContext242.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext243 = r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext243 ContextPropertySwitchInterpreter
				if(subContext243 != null)
				{
					
					{
						TaleNode subContext244 = (TaleNode)subContext243.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext244 ContextSwitchInterpreter
						if(subContext244 != null)
						{
							
							subContext244.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext245 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext245 ContextPropertySwitchInterpreter
				if(subContext245 != null)
				{
					
					{
						TaleNode subContext246 = (TaleNode)subContext245.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext246 ContextSwitchInterpreter
						if(subContext246 != null)
						{
							
							subContext246.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext247 = cris_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext247 ContextPropertySwitchInterpreter
				if(subContext247 != null)
				{
					
					{
						TaleNode subContext248 = (TaleNode)subContext247.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext248 ContextSwitchInterpreter
						if(subContext248 != null)
						{
							
							subContext248.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class conflict_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar258 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable249 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable249 != null)
			{
				Blackboards.conflict_node StoredVariable250 = ((Blackboards.conflict_node)StoredVariable249.GetComponent(typeof(Blackboards.conflict_node))); //IsContext = False IsNew = False
				if(StoredVariable250 != null)
				{
					TaleNode StoredVariable251 = ((TaleNode)StoredVariable250.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable251 != null)
					{
						System.Boolean ifResult252; //IsContext = False IsNew = False
						
						System.Boolean OperandVar255 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar253 = default(System.String); //IsContext = False IsNew = False
						OperandVar253 = "decomposed";
						System.Boolean prop254 = StoredVariable249.HasMarker( (OperandVar253)); //IsContext = False IsNew = False
						OperandVar255 = prop254;
						
						System.Boolean OperandVar257 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop256 = StoredVariable251.IsActive; //IsContext = False IsNew = False
						OperandVar257 = prop256;
						if(ifResult252 = ( (!(OperandVar255))) && ( ( (OperandVar257))))
						{
							applicable = true;
							OperandVar258 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar258);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			for (int i = 0; i <  (2f); i++)
			{
				UnityEngine.GameObject f_node = new UnityEngine.GameObject("f_node"); //IsContext = False IsNew = False
				
				{
					UnityEngine.GameObject f_node259 = f_node; //IsContext = True IsNew = False
					TaleNode AddContext260 = (TaleNode)f_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
					Blackboards.faction_node AddContext261 = (Blackboards.faction_node)f_node.AddComponent(typeof(Blackboards.faction_node)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Blackboards.faction_node AddContext261 ContextSwitchInterpreter
						if(AddContext261 != null)
						{
							UnityEngine.GameObject OperandVar262 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar262 = root;
							AddContext261.Conflict = (UnityEngine.GameObject)( (OperandVar262));
						}
					}
					Markers AddContext263 = (Markers)f_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				}
				UnityEngine.Object.FindObjectOfType<Generators>().Generate(f_node);
				
				{
					UnityEngine.GameObject subContext264 = f_node; //IsContext = True IsNew = False
					//ContextStatement UnityEngine.GameObject subContext264 ContextPropertySwitchInterpreter
					if(subContext264 != null)
					{
						
						{
							TaleNode subContext265 = (TaleNode)subContext264.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
							//ContextStatement TaleNode subContext265 ContextSwitchInterpreter
							if(subContext265 != null)
							{
								
								subContext265.IsActive = (System.Boolean)( (true));
							}
						}
					}
				}
			}
			
			{
				Markers subContext266 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext266 ContextSwitchInterpreter
				if(subContext266 != null)
				{
					System.String OperandVar267 = default(System.String); //IsContext = False IsNew = False
					OperandVar267 = "decomposed";
					subContext266.SetMarker(( (OperandVar267)).ToString());
				}
			}
		}
        }
    }
    
    public class tale_ui_enlisting : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar274 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable268 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable268 != null)
			{
				TaleNode StoredVariable269 = ((TaleNode)StoredVariable268.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
				if(StoredVariable269 != null)
				{
					System.Boolean ifResult270; //IsContext = False IsNew = False
					System.Boolean OperandVar273 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar271 = default(System.String); //IsContext = False IsNew = False
					OperandVar271 = "tale_enlisted";
					System.Boolean prop272 = StoredVariable268.HasMarker( (OperandVar271)); //IsContext = False IsNew = False
					OperandVar273 = prop272;
					if(ifResult270 = !(OperandVar273))
					{
						applicable = true;
						OperandVar274 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar274);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject ui = new UnityEngine.GameObject("ui"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject ui275 = ui; //IsContext = True IsNew = False
				UiObject AddContext276 = (UiObject)ui.AddComponent(typeof(UiObject)); //IsContext = True IsNew = True
				
				{
					//ContextStatement UiObject AddContext276 ContextSwitchInterpreter
					if(AddContext276 != null)
					{
						UnityEngine.GameObject OperandVar277 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar277 = root;
						AddContext276.ShowedObject = (UnityEngine.GameObject)( (OperandVar277));
						
						{
							UnityEngine.UI.LayoutElement subContext278 = AddContext276.Layout; //IsContext = True IsNew = False
							//ContextStatement UnityEngine.UI.LayoutElement subContext278 ContextPropertySwitchInterpreter
							if(subContext278 != null)
							{
								
								subContext278.minHeight = (System.Single)( (30f));
							}
						}
					}
				}
				TextField AddContext279 = (TextField)ui.AddComponent(typeof(TextField)); //IsContext = True IsNew = True
				
				{
					//ContextStatement TextField AddContext279 ContextSwitchInterpreter
					if(AddContext279 != null)
					{
						
						{
							UnityEngine.UI.LayoutElement subContext280 = AddContext279.Layout; //IsContext = True IsNew = False
							//ContextStatement UnityEngine.UI.LayoutElement subContext280 ContextPropertySwitchInterpreter
							if(subContext280 != null)
							{
								
								subContext280.minHeight = (System.Single)( (20f));
							}
						}
						System.String OperandVar283 = default(System.String); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar281 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar281 = root;
						System.String prop282 = External.Stringify( (OperandVar281)); //IsContext = False IsNew = False
						if(prop282 != null)
						{
							OperandVar283 = prop282;
						}
						AddContext279.Show(( (OperandVar283)).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(ui);
			UnityEngine.GameObject OperandVar284 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar284 = ui;
			External.TalesUiEnlist((UnityEngine.GameObject)( (OperandVar284)));
			
			{
				Markers subContext285 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext285 ContextSwitchInterpreter
				if(subContext285 != null)
				{
					System.String OperandVar286 = default(System.String); //IsContext = False IsNew = False
					OperandVar286 = "tale_enlisted";
					subContext285.SetMarker(( (OperandVar286)).ToString());
				}
			}
		}
        }
    }
}
